using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class PermissionPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Name { get; set; }

        [Required(ErrorMessageResourceName = "CodeRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MinLength(3, ErrorMessageResourceName = "CodeMinimumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(3, ErrorMessageResourceName = "CodeMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Code { get; set; }
    }
    public class PermissionPutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
        
        [MinLength(3, ErrorMessageResourceName = "CodeMinimumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(3, ErrorMessageResourceName = "CodeMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Code { get; set; }
    }
    public class PermissionGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
        
        [MinLength(3, ErrorMessageResourceName = "CodeMinimumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(3, ErrorMessageResourceName = "CodeMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Code { get; set; }
    }
}
