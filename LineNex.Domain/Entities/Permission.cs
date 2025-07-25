using System.ComponentModel.DataAnnotations;
using LineNex.Domain.Entity;

namespace LineNex.Domain.Entity
{
    public class Permission : BaseEntity
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public virtual IList<RolePermission> RolePermissions { get; set; } = [];
    }
}
