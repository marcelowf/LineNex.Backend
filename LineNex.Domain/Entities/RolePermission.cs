using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LineNex.Domain.Entity;

namespace LineNex.Domain.Entity
{
    public class RolePermission : BaseEntity
    {
        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
        
        [ForeignKey("Permission")]
        public Guid PermissionId { get; set; }
        public Permission? Permission { get; set; }
    }
}
