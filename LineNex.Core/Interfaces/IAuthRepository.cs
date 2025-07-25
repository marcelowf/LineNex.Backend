using LineNex.Domain.Entity;

namespace LineNex.Core.Interfaces
{
    public interface IAuthRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task<Role?> GetRoleByCodeAsync(string code);
        Task SaveChangesAsync();
        Task AddRefreshTokenAsync(ApplicationToken token);
        Task<ApplicationToken?> GetRefreshTokenAsync(string token);
        Task RevokeRefreshTokenAsync(ApplicationToken token);
        Task<IList<Permission>> GetPermissionsByUserIdAsync(Guid userId);
        Task AddEmailConfirmationTokenAsync(ApplicationToken applicationToken);
        Task<ApplicationToken?> GetEmailConfirmationTokenAsync(string token);
        Task<User?> GetUserByIdAsync(Guid userId);
        Task RevokeToken(string token);
        Task<User?> GetUserByToken(string token);
        void UpdateUserAsync(User user);
    }
}
