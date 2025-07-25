
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class CompanyController : BaseController<CompanyDto, CompanyPostModel, CompanyPutModel, ICompanyApplicationService, CompanyGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="CompanyController"/>.
        /// </summary>
        /// <param name="companyApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public CompanyController(ICompanyApplicationService companyApplicationService)
            : base(companyApplicationService)
        {
        }
    }
}
