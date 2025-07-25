
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class MachineTagService : BaseService<MachineTag, MachineTagGetModel>, IMachineTagService
    {
        private readonly IMachineTagRepository machineTagRepository;

        public MachineTagService(IMachineTagRepository machineTagRepository) : base(machineTagRepository)
        {
            this.machineTagRepository = machineTagRepository;
        }
    }
}