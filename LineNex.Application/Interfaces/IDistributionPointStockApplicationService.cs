using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IDistributionPointStockApplicationService : IBaseApplicationService<DistributionPointStockDto, DistributionPointStockPostModel, DistributionPointStockPutModel, DistributionPointStockGetModel>
    {
    }
}
