
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class ProductionLineRepository : BaseRepository<ProductionLine, ProductionLineGetModel>, IProductionLineRepository
    {
        private readonly SqlContext sqlContext;
        public ProductionLineRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
