using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IPermissionApplicationService : IBaseApplicationService<PermissionDto, PermissionPostModel, PermissionPutModel, PermissionGetModel>
    {
    }
}
