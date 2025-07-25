using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class Layout : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}