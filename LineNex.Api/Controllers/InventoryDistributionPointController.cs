
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class InventoryDistributionPointController : BaseController<InventoryDistributionPointDto, InventoryDistributionPointPostModel, InventoryDistributionPointPutModel, IInventoryDistributionPointApplicationService, InventoryDistributionPointGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="InventoryDistributionPointController"/>.
        /// </summary>
        /// <param name="inventoryDistributionPointApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public InventoryDistributionPointController(IInventoryDistributionPointApplicationService inventoryDistributionPointApplicationService)
            : base(inventoryDistributionPointApplicationService)
        {
        }
    }
}
