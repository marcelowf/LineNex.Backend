
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class RolePermissionRepository : BaseRepository<RolePermission, RolePermissionGetModel>, IRolePermissionRepository
    {
        private readonly SqlContext sqlContext;
        public RolePermissionRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
