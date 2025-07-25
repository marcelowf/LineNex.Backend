
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class DistributionPointMachineController : BaseController<DistributionPointMachineDto, DistributionPointMachinePostModel, DistributionPointMachinePutModel, IDistributionPointMachineApplicationService, DistributionPointMachineGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="DistributionPointMachineController"/>.
        /// </summary>
        /// <param name="distributionPointMachineApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public DistributionPointMachineController(IDistributionPointMachineApplicationService distributionPointMachineApplicationService)
            : base(distributionPointMachineApplicationService)
        {
        }
    }
}
