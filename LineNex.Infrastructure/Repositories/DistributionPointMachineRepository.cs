
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class DistributionPointMachineRepository : BaseRepository<DistributionPointMachine, DistributionPointMachineGetModel>, IDistributionPointMachineRepository
    {
        private readonly SqlContext sqlContext;
        public DistributionPointMachineRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
