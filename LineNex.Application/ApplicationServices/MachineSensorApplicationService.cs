using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class MachineSensorApplicationService : BaseApplicationService<MachineSensorDto, MachineSensorPostModel, MachineSensorPutModel, MachineSensorGetModel, MachineSensor>, IMachineSensorApplicationService
    {
        private readonly IMachineSensorService machineSensorService;

        public MachineSensorApplicationService(IMapper mapper, IMachineSensorService machineSensorService)
            : base(mapper, (IBaseService<MachineSensor, MachineSensorGetModel>)machineSensorService)
        {
            this.machineSensorService = machineSensorService;
        }
    }
}
