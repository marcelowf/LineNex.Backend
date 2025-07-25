using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class ProductionLinePostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Name { get; set; }
        
        [Required(ErrorMessageResourceName = "CompanyIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required Guid CompanyId { get; set; }
    }
    public class ProductionLinePutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
        public Guid? CompanyId { get; set; }
    }
    public class ProductionLineGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Name { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
