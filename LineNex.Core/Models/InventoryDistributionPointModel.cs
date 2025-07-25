using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class InventoryDistributionPointPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "InventoryIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid InventoryId { get; set; }
        
        [Required(ErrorMessageResourceName = "DistributionPointIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid DistributionPointId { get; set; }
    }
    public class InventoryDistributionPointPutModel : BasePutModel
    {
        public Guid? InventoryId { get; set; }
        public Guid? DistributionPointId { get; set; }
    }
    public class InventoryDistributionPointGetModel : BaseGetModel
    {
        public Guid? InventoryId { get; set; }
        public Guid? DistributionPointId { get; set; }
    }
}
