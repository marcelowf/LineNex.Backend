using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IDistributionPointApplicationService : IBaseApplicationService<DistributionPointDto, DistributionPointPostModel, DistributionPointPutModel, DistributionPointGetModel>
    {
    }
}
