
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class DistributionPointController : BaseController<DistributionPointDto, DistributionPointPostModel, DistributionPointPutModel, IDistributionPointApplicationService, DistributionPointGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="DistributionPointController"/>.
        /// </summary>
        /// <param name="distributionPointApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public DistributionPointController(IDistributionPointApplicationService distributionPointApplicationService)
            : base(distributionPointApplicationService)
        {
        }
    }
}
