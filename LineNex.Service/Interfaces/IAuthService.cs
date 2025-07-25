namespace LineNex.Service.Interfaces
{
    public interface IAuthService
    {
        Task RegisterAsync(string name, string email, string password);
        Task ActivateAccountAsync(string token);
        Task<(string JwtToken, string RefreshToken)> GetTokensAsync(string email, string password);
        Task<(string JwtToken, string RefreshToken)> RefreshTokenAsync(string refreshToken);
        Task ForgotPasswordAsync(string email);
        Task SetUpNewPasswordAsync(string password, string confirmPassword, string forgotPasswordToken);
    }
}
