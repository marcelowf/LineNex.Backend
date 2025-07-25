using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IProductionLineMachineApplicationService : IBaseApplicationService<ProductionLineMachineDto, ProductionLineMachinePostModel, ProductionLineMachinePutModel, ProductionLineMachineGetModel>
    {
    }
}
