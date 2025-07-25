using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class ProductionLine : BaseEntity
    {
        public required string Name { get; set; }
        
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
        public ICollection<ProductionLineMachine>? ProductionLineMachines { get; set; }
    }
}