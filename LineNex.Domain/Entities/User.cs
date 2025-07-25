using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class User : BaseEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required bool EmailConfirmed { get; set; }

        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }

        public ICollection<UserCompany>? UserCompanies { get; set; }
        public ICollection<ApplicationToken>? RefreshTokens { get; set; }
    }
}