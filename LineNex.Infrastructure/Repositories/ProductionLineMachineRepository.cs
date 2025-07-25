
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class ProductionLineMachineRepository : BaseRepository<ProductionLineMachine, ProductionLineMachineGetModel>, IProductionLineMachineRepository
    {
        private readonly SqlContext sqlContext;
        public ProductionLineMachineRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
