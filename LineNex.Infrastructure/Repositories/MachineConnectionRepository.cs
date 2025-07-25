
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class MachineConnectionRepository : BaseRepository<MachineConnection, MachineConnectionGetModel>, IMachineConnectionRepository
    {
        private readonly SqlContext sqlContext;
        public MachineConnectionRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
