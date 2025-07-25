using LineNex.Core.Interfaces;
using LineNex.Core.Models;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class ProductionLineService : BaseService<ProductionLine, ProductionLineGetModel>, IProductionLineService
    {
        private readonly IProductionLineRepository productLineRepository;

        public ProductionLineService(IProductionLineRepository productLineRepository) : base(productLineRepository)
        {
            this.productLineRepository = productLineRepository;
        }
    }
}