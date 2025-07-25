using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class RegisterModel
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
    }

    public class ActivateAccountModel
    {
        [Required(ErrorMessageResourceName = "ActivateTokenRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string ActivationToken { get; set; }
    }

    public class GetTokenModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "EmailMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [EmailAddress(ErrorMessageResourceName = "EmailInvalidFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Email { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "PasswordMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Password { get; set; }
    }

    public class RefreshTokenModel
    {
        [Required(ErrorMessageResourceName = "RefreshTokenRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string RefreshToken { get; set; }
    }

    public class ForgotPasswordModel
    {
        [Required(ErrorMessageResourceName = "EmailRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "EmailMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [EmailAddress(ErrorMessageResourceName = "EmailInvalidFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Email { get; set; }
    }

    public class SetUpNewPasswordModel
    {
        [Required(ErrorMessageResourceName = "PasswordRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "PasswordMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Password { get; set; }

        [Required(ErrorMessageResourceName = "PasswordRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "PasswordMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string ConfirmPassword { get; set; }
        
        [Required(ErrorMessageResourceName = "ForgotPasswordTokenRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string ForgotPasswordToken { get; set; }
    }

    public class GetTokenResponseModel
    {
        public string? JwtToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
