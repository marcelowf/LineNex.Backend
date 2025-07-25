
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class MachineConnectionController : BaseController<MachineConnectionDto, MachineConnectionPostModel, MachineConnectionPutModel, IMachineConnectionApplicationService, MachineConnectionGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="MachineConnectionController"/>.
        /// </summary>
        /// <param name="machineConnectionApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public MachineConnectionController(IMachineConnectionApplicationService machineConnectionApplicationService)
            : base(machineConnectionApplicationService)
        {
        }
    }
}
