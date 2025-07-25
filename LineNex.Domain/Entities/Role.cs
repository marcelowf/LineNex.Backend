using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class Role : BaseEntity
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public virtual IList<RolePermission>? RolePermissions { get; set; } = [];
    }
}
