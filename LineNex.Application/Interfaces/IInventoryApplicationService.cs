using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IInventoryApplicationService : IBaseApplicationService<InventoryDto, InventoryPostModel, InventoryPutModel, InventoryGetModel>
    {
    }
}
