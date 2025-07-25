using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class MachinePostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Name { get; set; }
    }
    public class MachinePutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
    }
    public class MachineGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
    }
}
