using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class DistributionPoint : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<DistributionPointMachine>? DistributionPointMachines { get; set; }
        public ICollection<DistributionPointStock>? DistributionPointStocks { get; set; }
        public ICollection<InventoryDistributionPoint>? InventoryDistributionPoints { get; set; }
    }
}