using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class MachineApplicationService : BaseApplicationService<MachineDto, MachinePostModel, MachinePutModel, MachineGetModel, Machine>, IMachineApplicationService
    {
        private readonly IMachineService machineService;

        public MachineApplicationService(IMapper mapper, IMachineService machineService)
            : base(mapper, (IBaseService<Machine, MachineGetModel>)machineService)
        {
            this.machineService = machineService;
        }
    }
}
