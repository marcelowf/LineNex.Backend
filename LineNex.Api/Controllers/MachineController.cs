
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class MachineController : BaseController<MachineDto, MachinePostModel, MachinePutModel, IMachineApplicationService, MachineGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="MachineController"/>.
        /// </summary>
        /// <param name="machineApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public MachineController(IMachineApplicationService machineApplicationService)
            : base(machineApplicationService)
        {
        }
    }
}
