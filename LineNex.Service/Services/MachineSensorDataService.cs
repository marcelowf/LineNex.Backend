
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class MachineSensorDataService : BaseService<MachineSensorData, MachineSensorDataGetModel>, IMachineSensorDataService
    {
        private readonly IMachineSensorDataRepository machineSensorDataRepository;

        public MachineSensorDataService(IMachineSensorDataRepository machineSensorDataRepository) : base(machineSensorDataRepository)
        {
            this.machineSensorDataRepository = machineSensorDataRepository;
        }
    }
}