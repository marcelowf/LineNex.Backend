using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;
using LineNex.Domain.Entity;

namespace LineNex.Application.Applications
{
    public class PermissionApplicationService : BaseApplicationService<PermissionDto, PermissionPostModel, PermissionPutModel, PermissionGetModel, Permission>, IPermissionApplicationService
    {
        private readonly IPermissionService permissionService;

        public PermissionApplicationService(IMapper mapper, IPermissionService permissionService)
            : base(mapper, (IBaseService<Permission, PermissionGetModel>)permissionService)
        {
            this.permissionService = permissionService;
        }
    }
}
