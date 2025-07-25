using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class MachineTagDto : BaseDto
    {
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
        public Guid TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
