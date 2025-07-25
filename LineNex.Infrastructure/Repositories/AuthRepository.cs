using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace LineNex.Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SqlContext _context;
        public AuthRepository(SqlContext context) => _context = context;

        public async Task<User?> GetByEmailAsync(string email) =>
            await _context.User
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Email == email);


        public async Task<Role?> GetRoleByCodeAsync(string code) =>
            await _context.Role.FirstOrDefaultAsync(r => r.Code == code);

        public async Task SaveChangesAsync() =>
            await _context.SaveChangesAsync();

        public async Task<IList<Permission>> GetPermissionsByUserIdAsync(Guid userId)
        {
            var user = await _context.User
                .AsNoTracking()
                .Include(u => u.Role!)
                    .ThenInclude(r => r.RolePermissions!)
                        .ThenInclude(rp => rp.Permission)
                .FirstOrDefaultAsync(u => u.Id == userId);

            return user?.Role?.RolePermissions
                        .Select(rp => rp.Permission!)
                        .ToList()
                   ?? new List<Permission>();
        }

        public async Task AddRefreshTokenAsync(ApplicationToken token) =>
            await _context.Set<ApplicationToken>().AddAsync(token);

        public async Task<ApplicationToken?> GetRefreshTokenAsync(string token) =>
            await _context.Set<ApplicationToken>()
                .Include(rt => rt.User)
                .FirstOrDefaultAsync(rt => rt.Token == token);

        public async Task RevokeRefreshTokenAsync(ApplicationToken token)
        {
            token.Revoked = DateTime.UtcNow;
            _context.Set<ApplicationToken>().Update(token);
        }

        public async Task AddEmailConfirmationTokenAsync(ApplicationToken applicationToken) =>
            await _context.ApplicationToken.AddAsync(applicationToken);

        public async Task<ApplicationToken?> GetEmailConfirmationTokenAsync(string token) =>
            await _context.ApplicationToken
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Token == token);

        public async Task<User?> GetUserByIdAsync(Guid userId) =>
            await _context.User.FirstOrDefaultAsync(u => u.Id == userId);

        public async Task<User?> GetUserByToken(string token)
        {
            var entity = await _context.ApplicationToken.FirstOrDefaultAsync(t => t.Token == token && t.Revoked == null && t.Expires > DateTime.UtcNow);

            if (entity == null)
                return null;

            return await _context.User.FirstOrDefaultAsync(u => u.Id == entity.UserId);
        }

        public async Task RevokeToken(string token)
        {
            var tokenEntity = await _context.ApplicationToken.FirstOrDefaultAsync(t => t.Token == token);

            if (tokenEntity != null)
            {
                tokenEntity.Revoked = DateTime.UtcNow;
                _context.ApplicationToken.Update(tokenEntity);
                await _context.SaveChangesAsync();
            }
        }

        public void UpdateUserAsync(User user)
        {
            _context.User.Update(user);
        }

        public async Task AddUserAsync(User user) =>
            await _context.User.AddAsync(user);
    }
}
