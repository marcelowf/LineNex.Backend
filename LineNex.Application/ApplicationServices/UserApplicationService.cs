using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class UserApplicationService : BaseApplicationService<UserDto, UserPostModel, UserPutModel, UserGetModel, User>, IUserApplicationService
    {
        private readonly IUserService userService;

        public UserApplicationService(IMapper mapper, IUserService userService)
            : base(mapper, (IBaseService<User, UserGetModel>)userService)
        {
            this.userService = userService;
        }
    }
}
