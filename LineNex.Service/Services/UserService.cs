
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class UserService : BaseService<User, UserGetModel>, IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}