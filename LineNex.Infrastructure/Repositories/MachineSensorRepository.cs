
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class MachineSensorRepository : BaseRepository<MachineSensor, MachineSensorGetModel>, IMachineSensorRepository
    {
        private readonly SqlContext sqlContext;
        public MachineSensorRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
