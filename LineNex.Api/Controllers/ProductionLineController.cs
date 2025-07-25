
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class ProductionLineController : BaseController<ProductionLineDto, ProductionLinePostModel, ProductionLinePutModel, IProductionLineApplicationService, ProductionLineGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="ProductionLineController"/>.
        /// </summary>
        /// <param name="productLineApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public ProductionLineController(IProductionLineApplicationService productLineApplicationService)
            : base(productLineApplicationService)
        {
        }
    }
}
