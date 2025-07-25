
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class DistributionPointStockRepository : BaseRepository<DistributionPointStock, DistributionPointStockGetModel>, IDistributionPointStockRepository
    {
        private readonly SqlContext sqlContext;
        public DistributionPointStockRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
