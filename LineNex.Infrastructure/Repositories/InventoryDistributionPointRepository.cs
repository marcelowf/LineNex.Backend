
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class InventoryDistributionPointRepository : BaseRepository<InventoryDistributionPoint, InventoryDistributionPointGetModel>, IInventoryDistributionPointRepository
    {
        private readonly SqlContext sqlContext;
        public InventoryDistributionPointRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
