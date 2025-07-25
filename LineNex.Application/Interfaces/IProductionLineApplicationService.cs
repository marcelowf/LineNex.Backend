using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IProductionLineApplicationService : IBaseApplicationService<ProductionLineDto, ProductionLinePostModel, ProductionLinePutModel, ProductionLineGetModel>
    {
    }
}
