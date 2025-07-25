using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class RoleApplicationService : BaseApplicationService<RoleDto, RolePostModel, RolePutModel, RoleGetModel, Role>, IRoleApplicationService
    {
        private readonly IRoleService roleService;

        public RoleApplicationService(IMapper mapper, IRoleService roleService)
            : base(mapper, (IBaseService<Role, RoleGetModel>)roleService)
        {
            this.roleService = roleService;
        }
    }
}
