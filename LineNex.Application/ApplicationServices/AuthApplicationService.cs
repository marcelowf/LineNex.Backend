using LineNex.Application.Dtos;
using LineNex.Application.Interfaces;
using LineNex.Core.Models;
using LineNex.Service.Interfaces;

namespace LineNex.Application.Applications
{
    public class AuthApplicationService : IAuthApplicationService
    {
        private readonly IAuthService _authService;
        public AuthApplicationService(IAuthService authService)
            => _authService = authService;

        public async Task RegisterAsync(RegisterModel dto)
        {
            await _authService.RegisterAsync(dto.Name, dto.Email, dto.Password);
        }

        public async Task ActivateAccountAsync(ActivateAccountModel dto)
        {
            await _authService.ActivateAccountAsync(dto.ActivationToken);
        }

        public async Task<(string JwtToken, string RefreshToken)> GetTokensAsync(GetTokenModel dto)
        {
            return await _authService.GetTokensAsync(dto.Email, dto.Password);
        }

        public async Task<(string JwtToken, string RefreshToken)> RefreshTokenAsync(string refreshToken)
        {
            return await _authService.RefreshTokenAsync(refreshToken);
        }

        public async Task ForgotPasswordAsync(ForgotPasswordModel dto)
        {
            await _authService.ForgotPasswordAsync(dto.Email);    
        }

        public async Task SetUpNewPasswordAsync(SetUpNewPasswordModel dto)
        {
            await _authService.SetUpNewPasswordAsync(dto.Password, dto.ConfirmPassword, dto.ForgotPasswordToken);
        }
    }
}
