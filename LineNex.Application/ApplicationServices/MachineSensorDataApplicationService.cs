using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class MachineSensorDataApplicationService : BaseApplicationService<MachineSensorDataDto, MachineSensorDataPostModel, MachineSensorDataPutModel, MachineSensorDataGetModel, MachineSensorData>, IMachineSensorDataApplicationService
    {
        private readonly IMachineSensorDataService machineSensorDataService;

        public MachineSensorDataApplicationService(IMapper mapper, IMachineSensorDataService machineSensorDataService)
            : base(mapper, (IBaseService<MachineSensorData, MachineSensorDataGetModel>)machineSensorDataService)
        {
            this.machineSensorDataService = machineSensorDataService;
        }
    }
}
