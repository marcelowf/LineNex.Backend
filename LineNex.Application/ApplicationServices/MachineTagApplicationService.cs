using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class MachineTagApplicationService : BaseApplicationService<MachineTagDto, MachineTagPostModel, MachineTagPutModel, MachineTagGetModel, MachineTag>, IMachineTagApplicationService
    {
        private readonly IMachineTagService machineTagService;

        public MachineTagApplicationService(IMapper mapper, IMachineTagService machineTagService)
            : base(mapper, (IBaseService<MachineTag, MachineTagGetModel>)machineTagService)
        {
            this.machineTagService = machineTagService;
        }
    }
}
