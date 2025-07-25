using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class UserCompanyApplicationService : BaseApplicationService<UserCompanyDto, UserCompanyPostModel, UserCompanyPutModel, UserCompanyGetModel, UserCompany>, IUserCompanyApplicationService
    {
        private readonly IUserCompanyService userCompanyService;

        public UserCompanyApplicationService(IMapper mapper, IUserCompanyService userCompanyService)
            : base(mapper, (IBaseService<UserCompany, UserCompanyGetModel>)userCompanyService)
        {
            this.userCompanyService = userCompanyService;
        }
    }
}
