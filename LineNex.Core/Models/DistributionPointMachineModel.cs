using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class DistributionPointMachinePostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "DistributionPointIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid DistributionPointId { get; set; }
        
        [Required(ErrorMessageResourceName = "MachineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid MachineId { get; set; }
    }
    public class DistributionPointMachinePutModel : BasePutModel
    {
        public Guid? DistributionPointId { get; set; }
        public Guid? MachineId { get; set; }
    }
    public class DistributionPointMachineGetModel : BaseGetModel
    {
        public Guid? DistributionPointId { get; set; }
        public Guid? MachineId { get; set; }
    }
}
