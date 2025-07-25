using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class RolePermissionApplicationService : BaseApplicationService<RolePermissionDto, RolePermissionPostModel, RolePermissionPutModel, RolePermissionGetModel, RolePermission>, IRolePermissionApplicationService
    {
        private readonly IRolePermissionService rolePermissionService;

        public RolePermissionApplicationService(IMapper mapper, IRolePermissionService rolePermissionService)
            : base(mapper, (IBaseService<RolePermission, RolePermissionGetModel>)rolePermissionService)
        {
            this.rolePermissionService = rolePermissionService;
        }
    }
}
