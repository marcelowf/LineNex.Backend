using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IAuthApplicationService
    {
        Task RegisterAsync(RegisterModel dto);
        Task ActivateAccountAsync(ActivateAccountModel dto);
        Task<(string JwtToken, string RefreshToken)> GetTokensAsync(GetTokenModel dto);
        Task<(string JwtToken, string RefreshToken)> RefreshTokenAsync(string refreshToken);
        Task ForgotPasswordAsync(ForgotPasswordModel dto);
        Task SetUpNewPasswordAsync(SetUpNewPasswordModel dto);
    }
}
