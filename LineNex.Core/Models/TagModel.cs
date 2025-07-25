using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class TagPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Name { get; set; }

        [Required(ErrorMessageResourceName = "ColorRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [RegularExpression("^#(?:[0-9a-fA-F]{3}){1,2}$", ErrorMessageResourceName = "ColorHexFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Color { get; set; }
    }
    public class TagPutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }

        [RegularExpression("^#(?:[0-9a-fA-F]{3}){1,2}$", ErrorMessageResourceName = "ColorHexFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Color { get; set; }
    }
    public class TagGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }

        [RegularExpression("^#(?:[0-9a-fA-F]{3}){1,2}$", ErrorMessageResourceName = "ColorHexFormatValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Color { get; set; }
    }
}
