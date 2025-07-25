using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class MachineTag : BaseEntity
    {
        [ForeignKey("Machine")]
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
        
        [ForeignKey("Tag")]
        public Guid TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}