using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class MachineSensorDto : BaseDto
    {
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
        public Guid SensorId { get; set; }
        public Sensor? Sensor { get; set; }
        public ICollection<MachineSensorData>? MachineSensorData { get; set; }
    }
}
