
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class CompanyService : BaseService<Company, CompanyGetModel>, ICompanyService
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyService(ICompanyRepository companyRepository) : base(companyRepository)
        {
            this.companyRepository = companyRepository;
        }
    }
}