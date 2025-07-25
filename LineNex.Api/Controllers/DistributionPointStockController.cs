
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class DistributionPointStockController : BaseController<DistributionPointStockDto, DistributionPointStockPostModel, DistributionPointStockPutModel, IDistributionPointStockApplicationService, DistributionPointStockGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="DistributionPointStockController"/>.
        /// </summary>
        /// <param name="distributionPointStockApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public DistributionPointStockController(IDistributionPointStockApplicationService distributionPointStockApplicationService)
            : base(distributionPointStockApplicationService)
        {
        }
    }
}
