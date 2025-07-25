using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class Company : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<UserCompany>? UserCompanies { get; set; }
        public ICollection<ProductionLine>? ProductionLines { get; set; }
    }
}