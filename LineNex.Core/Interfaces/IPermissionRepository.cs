
using LineNex.Domain.Entity;
using LineNex.Core.Models;

namespace LineNex.Core.Interfaces
{
    public interface IPermissionRepository : IBaseRepository<Permission, PermissionGetModel>
    {
    }
}
