using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class TagDto : BaseDto
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public ICollection<MachineTag>? MachineTags { get; set; }
    }
}
