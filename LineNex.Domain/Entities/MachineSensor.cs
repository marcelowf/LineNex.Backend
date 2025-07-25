using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class MachineSensor : BaseEntity
    {
        [ForeignKey("Machine")]
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
        
        [ForeignKey("Sensor")]
        public Guid SensorId { get; set; }
        public Sensor? Sensor { get; set; }
        public ICollection<MachineSensorData>? MachineSensorData { get; set; }
    }
}