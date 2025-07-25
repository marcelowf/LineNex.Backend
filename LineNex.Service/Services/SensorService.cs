
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class SensorService : BaseService<Sensor, SensorGetModel>, ISensorService
    {
        private readonly ISensorRepository sensorRepository;

        public SensorService(ISensorRepository sensorRepository) : base(sensorRepository)
        {
            this.sensorRepository = sensorRepository;
        }
    }
}