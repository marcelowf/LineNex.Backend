
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class ProductionLineMachineController : BaseController<ProductionLineMachineDto, ProductionLineMachinePostModel, ProductionLineMachinePutModel, IProductionLineMachineApplicationService, ProductionLineMachineGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="ProductionLineMachineController"/>.
        /// </summary>
        /// <param name="productLineMachineApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public ProductionLineMachineController(IProductionLineMachineApplicationService productLineMachineApplicationService)
            : base(productLineMachineApplicationService)
        {
        }
    }
}
