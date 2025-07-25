using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IMachineConnectionApplicationService : IBaseApplicationService<MachineConnectionDto, MachineConnectionPostModel, MachineConnectionPutModel, MachineConnectionGetModel>
    {
    }
}
