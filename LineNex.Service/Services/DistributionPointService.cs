
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class DistributionPointService : BaseService<DistributionPoint, DistributionPointGetModel>, IDistributionPointService
    {
        private readonly IDistributionPointRepository distributionPointRepository;

        public DistributionPointService(IDistributionPointRepository distributionPointRepository) : base(distributionPointRepository)
        {
            this.distributionPointRepository = distributionPointRepository;
        }
    }
}