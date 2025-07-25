
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class MachineSensorService : BaseService<MachineSensor, MachineSensorGetModel>, IMachineSensorService
    {
        private readonly IMachineSensorRepository machineSensorRepository;

        public MachineSensorService(IMachineSensorRepository machineSensorRepository) : base(machineSensorRepository)
        {
            this.machineSensorRepository = machineSensorRepository;
        }
    }
}