using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class MachineSensorData : BaseEntity
    {
        public Guid MachineSensorMachineId { get; set; }
        public Guid MachineSensorSensorId { get; set; }
        public required string Value { get; set; }
    }
}