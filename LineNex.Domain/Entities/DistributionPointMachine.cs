using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class DistributionPointMachine : BaseEntity
    {
        [ForeignKey("DistributionPoint")]
        public Guid DistributionPointId { get; set; }
        public DistributionPoint? DistributionPoint { get; set; }
        
        [ForeignKey("Machine")]
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
    }
}