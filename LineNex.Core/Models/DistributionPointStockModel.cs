using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LineNex.Core.Models
{
    public class DistributionPointStockPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "NameRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string ResourceName { get; set; }

        [Required(ErrorMessageResourceName = "QuantityRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [Range(0, int.MaxValue, ErrorMessageResourceName = "QuantityRangeValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required int Quantity { get; set; }

        [Required(ErrorMessageResourceName = "ValueRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        [MaxLength(500, ErrorMessageResourceName = "ValueMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Value { get; set; }
    }
    public class DistributionPointStockPutModel : BasePutModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? ResourceName { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "QuantityRangeValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public int? Quantity { get; set; }

        [MaxLength(500, ErrorMessageResourceName = "ValueMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Value { get; set; }
    }
    public class DistributionPointStockGetModel : BaseGetModel
    {
        [MaxLength(100, ErrorMessageResourceName = "NameMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? ResourceName { get; set; }

        [Range(0, int.MaxValue, ErrorMessageResourceName = "QuantityRangeValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public int? Quantity { get; set; }

        [MaxLength(500, ErrorMessageResourceName = "ValueMaximumLengthValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public string? Value { get; set; }
    }
}
