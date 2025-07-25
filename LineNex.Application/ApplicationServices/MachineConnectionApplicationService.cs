using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class MachineConnectionApplicationService : BaseApplicationService<MachineConnectionDto, MachineConnectionPostModel, MachineConnectionPutModel, MachineConnectionGetModel, MachineConnection>, IMachineConnectionApplicationService
    {
        private readonly IMachineConnectionService machineConnectionService;

        public MachineConnectionApplicationService(IMapper mapper, IMachineConnectionService machineConnectionService)
            : base(mapper, (IBaseService<MachineConnection, MachineConnectionGetModel>)machineConnectionService)
        {
            this.machineConnectionService = machineConnectionService;
        }
    }
}
