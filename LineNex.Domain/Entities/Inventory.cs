using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LineNex.Domain.Entity
{
    public class Inventory : BaseEntity
    {
        public required string ResourceName { get; set; }
        public int Quantity { get; set; }
        public required string Value { get; set; }
        public ICollection<InventoryDistributionPoint>? InventoryDistributionPoints { get; set; }
    }
}