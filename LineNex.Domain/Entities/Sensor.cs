using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class Sensor : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<MachineSensor>? MachineSensors { get; set; }
    }
}