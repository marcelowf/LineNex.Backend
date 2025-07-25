
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class SensorController : BaseController<SensorDto, SensorPostModel, SensorPutModel, ISensorApplicationService, SensorGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="SensorController"/>.
        /// </summary>
        /// <param name="sensorApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public SensorController(ISensorApplicationService sensorApplicationService)
            : base(sensorApplicationService)
        {
        }
    }
}
