using AutoMapper;
using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class CompanyApplicationService : BaseApplicationService<CompanyDto, CompanyPostModel, CompanyPutModel, CompanyGetModel, Company>, ICompanyApplicationService
    {
        private readonly ICompanyService companyService;

        public CompanyApplicationService(IMapper mapper, ICompanyService companyService)
            : base(mapper, (IBaseService<Company, CompanyGetModel>)companyService)
        {
            this.companyService = companyService;
        }
    }
}
