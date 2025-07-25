
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class UserCompanyController : BaseController<UserCompanyDto, UserCompanyPostModel, UserCompanyPutModel, IUserCompanyApplicationService, UserCompanyGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="UserCompanyController"/>.
        /// </summary>
        /// <param name="userCompanyApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public UserCompanyController(IUserCompanyApplicationService userCompanyApplicationService)
            : base(userCompanyApplicationService)
        {
        }
    }
}
