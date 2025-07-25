using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class RolePermissionPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "RoleIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid RoleId { get; set; }

        [Required(ErrorMessageResourceName = "PermissionIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid PermissionId { get; set; }
    }
    public class RolePermissionPutModel : BasePutModel
    {
        public Guid? RoleId { get; set; }
        public Guid? PermissionId { get; set; }
    }
    public class RolePermissionGetModel : BaseGetModel
    {
        public Guid? RoleId { get; set; }
        public Guid? PermissionId { get; set; }
    }
}
