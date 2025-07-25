using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class MachineSensorDataDto : BaseDto
    {
        public Guid MachineSensorMachineId { get; set; }
        public Guid MachineSensorSensorId { get; set; }
        public string? Value { get; set; }
    }
}
