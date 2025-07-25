
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class RoleController : BaseController<RoleDto, RolePostModel, RolePutModel, IRoleApplicationService, RoleGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="RoleController"/>.
        /// </summary>
        /// <param name="roleApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public RoleController(IRoleApplicationService roleApplicationService)
            : base(roleApplicationService)
        {
        }
    }
}
