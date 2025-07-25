using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class MachineConnection : BaseEntity
    {
        [ForeignKey("Machine")]
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
    }
}