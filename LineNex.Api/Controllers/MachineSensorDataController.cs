
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class MachineSensorDataController : BaseController<MachineSensorDataDto, MachineSensorDataPostModel, MachineSensorDataPutModel, IMachineSensorDataApplicationService, MachineSensorDataGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="MachineSensorDataController"/>.
        /// </summary>
        /// <param name="machineSensorDataApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public MachineSensorDataController(IMachineSensorDataApplicationService machineSensorDataApplicationService)
            : base(machineSensorDataApplicationService)
        {
        }
    }
}
