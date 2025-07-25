
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class PermissionController : BaseController<PermissionDto, PermissionPostModel, PermissionPutModel, IPermissionApplicationService, PermissionGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="PermissionController"/>.
        /// </summary>
        /// <param name="permissionApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public PermissionController(IPermissionApplicationService permissionApplicationService)
            : base(permissionApplicationService)
        {
        }
    }
}
