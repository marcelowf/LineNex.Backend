using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class InventoryDistributionPoint : BaseEntity
    {
        [ForeignKey("Inventory")]
        public Guid InventoryId { get; set; }
        public Inventory? Inventory { get; set; }
        
        [ForeignKey("DistributionPoint")]
        public Guid DistributionPointId { get; set; }
        public DistributionPoint? DistributionPoint { get; set; }
    }
}