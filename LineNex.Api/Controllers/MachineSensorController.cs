
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class MachineSensorController : BaseController<MachineSensorDto, MachineSensorPostModel, MachineSensorPutModel, IMachineSensorApplicationService, MachineSensorGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="MachineSensorController"/>.
        /// </summary>
        /// <param name="machineSensorApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public MachineSensorController(IMachineSensorApplicationService machineSensorApplicationService)
            : base(machineSensorApplicationService)
        {
        }
    }
}
