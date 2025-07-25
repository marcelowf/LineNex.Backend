
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory, InventoryGetModel>, IInventoryRepository
    {
        private readonly SqlContext sqlContext;
        public InventoryRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
