using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IUserCompanyApplicationService : IBaseApplicationService<UserCompanyDto, UserCompanyPostModel, UserCompanyPutModel, UserCompanyGetModel>
    {
    }
}
