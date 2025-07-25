
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class DistributionPointStockService : BaseService<DistributionPointStock, DistributionPointStockGetModel>, IDistributionPointStockService
    {
        private readonly IDistributionPointStockRepository distributionPointStockRepository;

        public DistributionPointStockService(IDistributionPointStockRepository distributionPointStockRepository) : base(distributionPointStockRepository)
        {
            this.distributionPointStockRepository = distributionPointStockRepository;
        }
    }
}