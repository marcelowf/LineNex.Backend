using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IMachineApplicationService : IBaseApplicationService<MachineDto, MachinePostModel, MachinePutModel, MachineGetModel>
    {
    }
}
