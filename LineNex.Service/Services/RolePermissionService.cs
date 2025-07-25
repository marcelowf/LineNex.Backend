
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class RolePermissionService : BaseService<RolePermission, RolePermissionGetModel>, IRolePermissionService
    {
        private readonly IRolePermissionRepository rolePermissionRepository;

        public RolePermissionService(IRolePermissionRepository rolePermissionRepository) : base(rolePermissionRepository)
        {
            this.rolePermissionRepository = rolePermissionRepository;
        }
    }
}