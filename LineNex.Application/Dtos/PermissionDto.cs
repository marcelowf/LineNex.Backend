using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class PermissionDto : BaseDto
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public virtual IList<RolePermission> RolePermissions { get; set; } = [];
    }
}
