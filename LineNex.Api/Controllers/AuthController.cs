using Microsoft.AspNetCore.Mvc;
using LineNex.Application.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    // [ApiVersion("1.0")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthApplicationService appService;
        public AuthController(IAuthApplicationService appService)
        {
            this.appService = appService;
        }

        /// <summary>
        /// Registers a new user and sends an email confirmation link.
        /// </summary>
        /// <param name="registerModel">User registration data.</param>
        /// <returns>Success message if registration was successful.</returns>
        // [MapToApiVersion("1.0")]
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            var allowedDomains = new[] { "@pucpr.edu.br", "@volvo.com" };

            if (!allowedDomains.Any(domain => registerModel.Email.EndsWith(domain, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest("Only emails from PUCPR or VOLVO are allowed.");
            }

            await appService.RegisterAsync(registerModel);
            return Ok("User successfully registered. Please check your email to activate your account.");
        }

        /// <summary>
        /// Confirms the user's account using the token sent via email.
        /// </summary>
        /// <param name="token">Confirmation token.</param>
        /// <returns>Success message if the account was activated.</returns>
        // [MapToApiVersion("1.0")]
        [HttpGet("ActivateAccount")]
        public async Task<IActionResult> ActivateAccount([FromQuery] string token)
        {
            await appService.ActivateAccountAsync(new ActivateAccountModel { ActivationToken = token });
            return Ok("Account activated successfully.");
        }

        /// <summary>
        /// Authenticates the user and returns a JWT + Refresh Token pair.
        /// </summary>
        /// <param name="getTokenModel">User credentials.</param>
        /// <returns>JWT and Refresh Token.</returns>
        // [MapToApiVersion("1.0")]
        [HttpPost("Login")]
        public async Task<IActionResult> GetToken([FromBody] GetTokenModel getTokenModel)
        {
            var (jwt, refresh) = await appService.GetTokensAsync(getTokenModel);
            return Ok(new GetTokenResponseModel
            {
                JwtToken = jwt,
                RefreshToken = refresh
            });
        }

        /// <summary>
        /// Refreshes the JWT using a valid refresh token.
        /// </summary>
        /// <param name="refreshTokenModel">Model containing the refresh token.</param>
        /// <returns>New JWT and Refresh Token.</returns>
        // [MapToApiVersion("1.0")]
        [HttpPost("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenModel refreshTokenModel)
        {
            var (jwt, refresh) = await appService.RefreshTokenAsync(refreshTokenModel.RefreshToken);
            return Ok(new GetTokenResponseModel
            {
                JwtToken = jwt,
                RefreshToken = refresh
            });
        }

        /// <summary>
        /// Sends a password reset token to the user's email.
        /// </summary>
        /// <param name="forgotPasswordModel">The model containing the user's email.</param>
        /// <returns>A message indicating the token was sent.</returns>
        // [MapToApiVersion("1.0")]
        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordModel forgotPasswordModel)
        {
            await appService.ForgotPasswordAsync(forgotPasswordModel);
            return Ok("Please check your email to confirm your identity.");
        }

        /// <summary>
        /// Updates the user's password using the token sent by email.
        /// </summary>
        /// <param name="setUpNewPasswordModel">The model containing the user's new password and token.</param>
        /// <returns>A message confirming the password was successfully updated.</returns>
        // [MapToApiVersion("1.0")]
        [HttpPost("SetUpNewPassword")]
        // The request must include: new password, confirm password, and the reset token.
        public async Task<IActionResult> SetUpNewPassword([FromBody] SetUpNewPasswordModel setUpNewPasswordModel)
        {
            await appService.SetUpNewPasswordAsync(setUpNewPasswordModel);
            return Ok("Password updated successfully.");
        }
    }
}
