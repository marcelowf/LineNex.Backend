
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class PermissionService : BaseService<Permission, PermissionGetModel>, IPermissionService
    {
        private readonly IPermissionRepository permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository) : base(permissionRepository)
        {
            this.permissionRepository = permissionRepository;
        }
    }
}