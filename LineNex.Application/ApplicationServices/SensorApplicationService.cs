using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class SensorApplicationService : BaseApplicationService<SensorDto, SensorPostModel, SensorPutModel, SensorGetModel, Sensor>, ISensorApplicationService
    {
        private readonly ISensorService sensorService;

        public SensorApplicationService(IMapper mapper, ISensorService sensorService)
            : base(mapper, (IBaseService<Sensor, SensorGetModel>)sensorService)
        {
            this.sensorService = sensorService;
        }
    }
}
