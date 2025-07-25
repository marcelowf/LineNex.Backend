using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IRoleApplicationService : IBaseApplicationService<RoleDto, RolePostModel, RolePutModel, RoleGetModel>
    {
    }
}
