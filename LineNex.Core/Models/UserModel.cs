using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class UserPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Name { get; set; }

        [Required(ErrorMessageResourceName = "EmailRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "EmailMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [EmailAddress(ErrorMessageResourceName = "EmailInvalidFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Email { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "PasswordMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Password { get; set; }

        [Required(ErrorMessageResourceName = "RoleIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required Guid RoleId { get; set; }
    }
    public class UserPutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }

        [MaxLength(100, ErrorMessageResourceName = "EmailMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [EmailAddress(ErrorMessageResourceName = "EmailInvalidFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Email { get; set; }
        public Guid? RoleId { get; set; }
    }
    public class UserGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }

        [MaxLength(100, ErrorMessageResourceName = "EmailMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [EmailAddress(ErrorMessageResourceName = "EmailInvalidFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Email { get; set; }
        public Guid? RoleId { get; set; }
    }
}
