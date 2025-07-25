
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class DistributionPointRepository : BaseRepository<DistributionPoint, DistributionPointGetModel>, IDistributionPointRepository
    {
        private readonly SqlContext sqlContext;
        public DistributionPointRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
