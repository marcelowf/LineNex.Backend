using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class SensorDto : BaseDto
    {
        public string? Name { get; set; }
        public ICollection<MachineSensor>? MachineSensors { get; set; }
    }
}
