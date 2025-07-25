
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class RolePermissionController : BaseController<RolePermissionDto, RolePermissionPostModel, RolePermissionPutModel, IRolePermissionApplicationService, RolePermissionGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="RolePermissionController"/>.
        /// </summary>
        /// <param name="rolePermissionApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public RolePermissionController(IRolePermissionApplicationService rolePermissionApplicationService)
            : base(rolePermissionApplicationService)
        {
        }
    }
}
