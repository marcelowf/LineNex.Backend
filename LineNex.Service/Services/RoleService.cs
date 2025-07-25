
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class RoleService : BaseService<Role, RoleGetModel>, IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository) : base(roleRepository)
        {
            this.roleRepository = roleRepository;
        }
    }
}