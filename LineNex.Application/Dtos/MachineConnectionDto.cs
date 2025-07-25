using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class MachineConnectionDto : BaseDto
    {
        public Guid ConnectedMachineId { get; set; }
        public Machine? ConnectedMachine { get; set; }
    }
}
