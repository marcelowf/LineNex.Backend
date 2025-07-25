using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IMachineTagApplicationService : IBaseApplicationService<MachineTagDto, MachineTagPostModel, MachineTagPutModel, MachineTagGetModel>
    {
    }
}
