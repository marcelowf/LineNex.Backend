using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class ProductionLineMachine : BaseEntity
    {
        [ForeignKey("ProductionLine")]
        public Guid ProductionLineId { get; set; }
        public ProductionLine? ProductionLine { get; set; }
        
        [ForeignKey("Machine")]
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
    }
}