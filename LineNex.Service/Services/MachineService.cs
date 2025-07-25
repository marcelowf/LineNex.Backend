
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class MachineService : BaseService<Machine, MachineGetModel>, IMachineService
    {
        private readonly IMachineRepository machineRepository;

        public MachineService(IMachineRepository machineRepository) : base(machineRepository)
        {
            this.machineRepository = machineRepository;
        }
    }
}