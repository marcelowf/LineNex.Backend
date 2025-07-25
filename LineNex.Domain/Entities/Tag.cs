using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class Tag : BaseEntity
    {
        public required string Name { get; set; }
        public required string Color { get; set; }
        public ICollection<MachineTag>? MachineTags { get; set; }
    }
}