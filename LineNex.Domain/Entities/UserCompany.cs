using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class UserCompany : BaseEntity
    {
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User? User { get; set; }
        
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}