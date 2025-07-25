using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IInventoryDistributionPointApplicationService : IBaseApplicationService<InventoryDistributionPointDto, InventoryDistributionPointPostModel, InventoryDistributionPointPutModel, InventoryDistributionPointGetModel>
    {
    }
}
