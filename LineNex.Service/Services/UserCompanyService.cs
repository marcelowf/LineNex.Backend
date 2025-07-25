
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class UserCompanyService : BaseService<UserCompany, UserCompanyGetModel>, IUserCompanyService
    {
        private readonly IUserCompanyRepository userCompanyRepository;

        public UserCompanyService(IUserCompanyRepository userCompanyRepository) : base(userCompanyRepository)
        {
            this.userCompanyRepository = userCompanyRepository;
        }
    }
}