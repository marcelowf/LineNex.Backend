
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class DistributionPointMachineService : BaseService<DistributionPointMachine, DistributionPointMachineGetModel>, IDistributionPointMachineService
    {
        private readonly IDistributionPointMachineRepository distributionPointMachineRepository;

        public DistributionPointMachineService(IDistributionPointMachineRepository distributionPointMachineRepository) : base(distributionPointMachineRepository)
        {
            this.distributionPointMachineRepository = distributionPointMachineRepository;
        }
    }
}