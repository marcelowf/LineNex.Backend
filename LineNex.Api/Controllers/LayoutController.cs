
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class LayoutController : BaseController<LayoutDto, LayoutPostModel, LayoutPutModel, ILayoutApplicationService, LayoutGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="LayoutController"/>.
        /// </summary>
        /// <param name="layoutApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public LayoutController(ILayoutApplicationService layoutApplicationService)
            : base(layoutApplicationService)
        {
        }
    }
}
