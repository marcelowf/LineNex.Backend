using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Service.Interfaces.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace LineNex.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly IEmailService _emailService;
        private readonly IPasswordHasher<User> _hasher;
        private readonly IConfiguration _config;
        private readonly ITokenGeneratorService _tokenGenerator;

        private const int JwtExpirationMinutes = 15;
        private const int RefreshTokenMinutes = 15;
        private const int EmailTokenMinutes = 15;

        private static class ErrorMessages
        {
            public const string EmailRequired = "Email is required.";
            public const string PasswordRequired = "Password is required.";
            public const string NameRequired = "Name is required.";
            public const string EmailInvalid = "Invalid email format.";
            public const string PasswordMismatch = "Passwords do not match.";
            public const string EmailAlreadyRegistered = "Email already registered.";
            public const string InvalidCredentials = "Invalid credentials.";
            public const string EmailNotConfirmed = "Email not yet confirmed. Please check your inbox.";
            public const string TokenExpiredOrRevoked = "Refresh token expired or revoked.";
            public const string TokenInvalid = "Invalid or expired token.";
            public const string UserNotFound = "User not found.";
        }

        public AuthService(
            IAuthRepository repository,
            IPasswordHasher<User> hasher,
            IConfiguration config,
            IEmailService emailService,
            ITokenGeneratorService tokenGenerator)
        {
            _repository = repository;
            _hasher = hasher;
            _config = config;
            _emailService = emailService;
            _tokenGenerator = tokenGenerator;
        }

        public async Task RegisterAsync(string name, string email, string password)
        {
            ValidateRequired(name, ErrorMessages.NameRequired);
            ValidateEmail(email);
            ValidateRequired(password, ErrorMessages.PasswordRequired);

            if (await _repository.GetByEmailAsync(email) != null)
                throw new InvalidOperationException(ErrorMessages.EmailAlreadyRegistered);

            var role = await _repository.GetRoleByCodeAsync("USER");

            var user = new User
            {
                Name = name,
                Email = email,
                Password = "",
                RoleId = role.Id,
                CreatedById = Guid.Empty,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = false,
                IsDeleted = false
            };

            user.Password = _hasher.HashPassword(user, password);

            await _repository.AddUserAsync(user);
            await _repository.SaveChangesAsync();

            await SendEmailTokenAsync(
                user,
                "Email Confirmation",
                (token) => $"{_config["BackendUrl"]}/api/v1/Auth/ActivateAccount?token={token}",
                "Please confirm your email address by clicking the link below:"
            );
        }

        public async Task ActivateAccountAsync(string token)
        {
            var confirmation = await _repository.GetEmailConfirmationTokenAsync(token)
                ?? throw new UnauthorizedAccessException(ErrorMessages.TokenInvalid);

            if (confirmation.Expires < DateTime.UtcNow)
                throw new UnauthorizedAccessException("Token has expired.");

            if (confirmation.Revoked != null)
                throw new UnauthorizedAccessException("Token has already been used.");

            var user = await _repository.GetUserByIdAsync(confirmation.UserId)
                ?? throw new InvalidOperationException(ErrorMessages.UserNotFound);

            user.EmailConfirmed = true;
            confirmation.Revoked = DateTime.UtcNow;

            await _repository.SaveChangesAsync();
        }

        public async Task<(string JwtToken, string RefreshToken)> GetTokensAsync(string email, string password)
        {
            ValidateEmail(email);
            ValidateRequired(password, ErrorMessages.PasswordRequired);

            var user = await _repository.GetByEmailAsync(email)
                ?? throw new UnauthorizedAccessException(ErrorMessages.InvalidCredentials);

            if (!user.EmailConfirmed)
                throw new UnauthorizedAccessException(ErrorMessages.EmailNotConfirmed);

            var verify = _hasher.VerifyHashedPassword(user, user.Password, password);
            if (verify != PasswordVerificationResult.Success)
                throw new UnauthorizedAccessException(ErrorMessages.InvalidCredentials);

            var jwt = await GenerateJwtAsync(user);
            var refreshToken = CreateRefreshToken(user.Id);

            await _repository.AddRefreshTokenAsync(refreshToken);
            await _repository.SaveChangesAsync();

            return (jwt, refreshToken.Token);
        }

        public async Task<(string JwtToken, string RefreshToken)> RefreshTokenAsync(string refreshToken)
        {
            if (string.IsNullOrWhiteSpace(refreshToken))
                throw new SecurityTokenException("Refresh token is required.");

            var existing = await _repository.GetRefreshTokenAsync(refreshToken)
                ?? throw new SecurityTokenException(ErrorMessages.TokenInvalid);

            if (existing.Expires <= DateTime.UtcNow || existing.Revoked != null)
                throw new SecurityTokenException(ErrorMessages.TokenExpiredOrRevoked);

            await _repository.RevokeRefreshTokenAsync(existing);

            var jwt = await GenerateJwtAsync(existing.User!);
            var newRefresh = CreateRefreshToken(existing.UserId);

            await _repository.AddRefreshTokenAsync(newRefresh);
            await _repository.SaveChangesAsync();

            await _repository.RevokeToken(refreshToken);

            return (jwt, newRefresh.Token);
        }

        public async Task ForgotPasswordAsync(string email)
        {
            ValidateEmail(email);

            var user = await _repository.GetByEmailAsync(email)
                ?? throw new UnauthorizedAccessException(ErrorMessages.InvalidCredentials);

            if (!user.EmailConfirmed)
                throw new UnauthorizedAccessException(ErrorMessages.EmailNotConfirmed);

            await SendEmailTokenAsync(
                user,
                "Password Reset – Identity Confirmation",
                _ => null,
                "To verify your identity and reset your password, please use the token below:",
                inlineToken: true
            );
        }

        public async Task SetUpNewPasswordAsync(string password, string confirmPassword, string forgotPasswordToken)
        {
            ValidateRequired(password, ErrorMessages.PasswordRequired);
            ValidateRequired(confirmPassword, "Confirm password is required.");

            if (password != confirmPassword)
                throw new Exception(ErrorMessages.PasswordMismatch);

            var user = await _repository.GetUserByToken(forgotPasswordToken)
                ?? throw new Exception(ErrorMessages.TokenInvalid);

            if (!user.EmailConfirmed)
                throw new UnauthorizedAccessException(ErrorMessages.EmailNotConfirmed);

            user.Password = _hasher.HashPassword(user, password);

            _repository.UpdateUserAsync(user);
            await _repository.SaveChangesAsync();

            await _repository.RevokeToken(forgotPasswordToken);
        }

        private async Task<string> GenerateJwtAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role?.Code ?? "")
            };

            var permissions = await _repository.GetPermissionsByUserIdAsync(user.Id);
            claims.AddRange(permissions.Select(p => new Claim("permission", p.Code)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtBearer:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["JwtBearer:TokenIssuer"],
                audience: _config["JwtBearer:TokenAudience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(JwtExpirationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private ApplicationToken CreateRefreshToken(Guid userId)
        {
            return new ApplicationToken
            {
                UserId = userId,
                Token = _tokenGenerator.Generate(),
                CreatedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddMinutes(RefreshTokenMinutes)
            };
        }

        private ApplicationToken CreateEmailToken(Guid userId, string tokenValue)
        {
            return new ApplicationToken
            {
                UserId = userId,
                Token = tokenValue,
                CreatedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddMinutes(EmailTokenMinutes)
            };
        }

        private async Task SendEmailTokenAsync(User user, string subject, Func<string, string?> urlBuilder, string messageBody, bool inlineToken = false)
        {
            var tokenValue = _tokenGenerator.Generate();
            var token = CreateEmailToken(user.Id, tokenValue);

            await _repository.AddEmailConfirmationTokenAsync(token);
            await _repository.SaveChangesAsync();

            string body;
            if (inlineToken)
            {
                body = $@"
                    <p>Hello {user.Name},</p>
                    <p>{messageBody}</p>
                    <p><strong>{tokenValue}</strong></p>
                    <p>This token will expire in {EmailTokenMinutes} minutes.</p>";
            }
            else
            {
                var url = urlBuilder(tokenValue);
                body = $@"
                    <p>Hello {user.Name},</p>
                    <p>{messageBody}</p>
                    <p><a href='{url}'>Click here</a></p>
                    <p>This link will expire in {EmailTokenMinutes} minutes.</p>";
            }

            await _emailService.SendEmailAsync(user.Email, subject, body);
        }

        private void ValidateRequired(string? value, string error)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(error);
        }

        private void ValidateEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException(ErrorMessages.EmailRequired);

            if (!email.Contains('@') || !email.Contains('.'))
                throw new ArgumentException(ErrorMessages.EmailInvalid);
        }
    }
}
