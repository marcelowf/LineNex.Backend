using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IDistributionPointMachineApplicationService : IBaseApplicationService<DistributionPointMachineDto, DistributionPointMachinePostModel, DistributionPointMachinePutModel, DistributionPointMachineGetModel>
    {
    }
}
