using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LineNex.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace LineNex.Domain.Entity
{
    [Index(nameof(Token), IsUnique = true)]
    public class ApplicationToken
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime Expires { get; set; }
        public DateTime? Revoked { get; set; }

        public required string Token { get; set; }
        
        // [Required]
        // public TokenType TokenType { get; set; }
    }
}