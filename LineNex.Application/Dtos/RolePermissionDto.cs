using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class RolePermissionDto : BaseDto
    {
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
        public Guid PermissionId { get; set; }
        public Permission? Permission { get; set; }
    }
}
