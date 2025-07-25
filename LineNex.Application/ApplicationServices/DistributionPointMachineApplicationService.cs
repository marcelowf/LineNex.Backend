using AutoMapper;
using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class DistributionPointMachineApplicationService : BaseApplicationService<DistributionPointMachineDto, DistributionPointMachinePostModel, DistributionPointMachinePutModel, DistributionPointMachineGetModel, DistributionPointMachine>, IDistributionPointMachineApplicationService
    {
        private readonly IDistributionPointMachineService distributionPointMachineService;

        public DistributionPointMachineApplicationService(IMapper mapper, IDistributionPointMachineService distributionPointMachineService)
            : base(mapper, (IBaseService<DistributionPointMachine, DistributionPointMachineGetModel>)distributionPointMachineService)
        {
            this.distributionPointMachineService = distributionPointMachineService;
        }
    }
}
