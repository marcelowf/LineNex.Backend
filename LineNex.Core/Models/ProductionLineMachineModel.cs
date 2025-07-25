using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class ProductionLineMachinePostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "ProductionLineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid ProductionLineId { get; set; }
        
        [Required(ErrorMessageResourceName = "MachineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid MachineId { get; set; }
    }
    public class ProductionLineMachinePutModel : BasePutModel
    {
        public Guid? ProductionLineId { get; set; }
        public Guid? MachineId { get; set; }
    }
    public class ProductionLineMachineGetModel : BaseGetModel
    {
        public Guid? ProductionLineId { get; set; }
        public Guid? MachineId { get; set; }
    }
}
