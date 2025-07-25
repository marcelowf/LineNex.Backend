
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class MachineSensorDataRepository : BaseRepository<MachineSensorData, MachineSensorDataGetModel>, IMachineSensorDataRepository
    {
        private readonly SqlContext sqlContext;
        public MachineSensorDataRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
