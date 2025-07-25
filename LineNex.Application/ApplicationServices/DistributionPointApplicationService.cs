using AutoMapper;
using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class DistributionPointApplicationService : BaseApplicationService<DistributionPointDto, DistributionPointPostModel, DistributionPointPutModel, DistributionPointGetModel, DistributionPoint>, IDistributionPointApplicationService
    {
        private readonly IDistributionPointService distributionPointService;

        public DistributionPointApplicationService(IMapper mapper, IDistributionPointService distributionPointService)
            : base(mapper, (IBaseService<DistributionPoint, DistributionPointGetModel>)distributionPointService)
        {
            this.distributionPointService = distributionPointService;
        }
    }
}
