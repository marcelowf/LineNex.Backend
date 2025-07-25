
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class PermissionRepository : BaseRepository<Permission, PermissionGetModel>, IPermissionRepository
    {
        private readonly SqlContext sqlContext;
        public PermissionRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
