using AutoMapper;
using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class DistributionPointStockApplicationService : BaseApplicationService<DistributionPointStockDto, DistributionPointStockPostModel, DistributionPointStockPutModel, DistributionPointStockGetModel, DistributionPointStock>, IDistributionPointStockApplicationService
    {
        private readonly IDistributionPointStockService distributionPointStockService;

        public DistributionPointStockApplicationService(IMapper mapper, IDistributionPointStockService distributionPointStockService)
            : base(mapper, (IBaseService<DistributionPointStock, DistributionPointStockGetModel>)distributionPointStockService)
        {
            this.distributionPointStockService = distributionPointStockService;
        }
    }
}
