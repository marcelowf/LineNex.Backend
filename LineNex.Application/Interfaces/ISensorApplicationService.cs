using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface ISensorApplicationService : IBaseApplicationService<SensorDto, SensorPostModel, SensorPutModel, SensorGetModel>
    {
    }
}
