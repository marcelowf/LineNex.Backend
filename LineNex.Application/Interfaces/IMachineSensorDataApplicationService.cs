using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IMachineSensorDataApplicationService : IBaseApplicationService<MachineSensorDataDto, MachineSensorDataPostModel, MachineSensorDataPutModel, MachineSensorDataGetModel>
    {
    }
}
