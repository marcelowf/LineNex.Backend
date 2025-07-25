using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class LayoutPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Name { get; set; }

        [MaxLength(500, ErrorMessageResourceName = "DescriptionMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Description { get; set; }
    }
    public class LayoutPutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }

        [MaxLength(500, ErrorMessageResourceName = "DescriptionMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Description { get; set; }
    }
    public class LayoutGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
        
        [MaxLength(500, ErrorMessageResourceName = "DescriptionMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Description { get; set; }
    }
}
