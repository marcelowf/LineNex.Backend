
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class MachineTagController : BaseController<MachineTagDto, MachineTagPostModel, MachineTagPutModel, IMachineTagApplicationService, MachineTagGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="MachineTagController"/>.
        /// </summary>
        /// <param name="machineTagApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public MachineTagController(IMachineTagApplicationService machineTagApplicationService)
            : base(machineTagApplicationService)
        {
        }
    }
}
