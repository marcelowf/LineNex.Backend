using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class MachineSensorPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "MachineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid MachineId { get; set; }
        
        [Required(ErrorMessageResourceName = "SensorIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid SensorId { get; set; }
    }
    public class MachineSensorPutModel : BasePutModel
    {
        public Guid? MachineId { get; set; }
        public Guid? SensorId { get; set; }
    }
    public class MachineSensorGetModel : BaseGetModel
    {
        public Guid? MachineId { get; set; }
        public Guid? SensorId { get; set; }
    }
}
