
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class InventoryController : BaseController<InventoryDto, InventoryPostModel, InventoryPutModel, IInventoryApplicationService, InventoryGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="InventoryController"/>.
        /// </summary>
        /// <param name="inventoryApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public InventoryController(IInventoryApplicationService inventoryApplicationService)
            : base(inventoryApplicationService)
        {
        }
    }
}
