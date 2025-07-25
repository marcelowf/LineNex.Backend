
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class MachineConnectionService : BaseService<MachineConnection, MachineConnectionGetModel>, IMachineConnectionService
    {
        private readonly IMachineConnectionRepository machineConnectionRepository;

        public MachineConnectionService(IMachineConnectionRepository machineConnectionRepository) : base(machineConnectionRepository)
        {
            this.machineConnectionRepository = machineConnectionRepository;
        }
    }
}