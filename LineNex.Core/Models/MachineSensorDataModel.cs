using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class MachineSensorDataPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "MachineSensorMachineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid MachineSensorMachineId { get; set; }

        [Required(ErrorMessageResourceName = "MachineSensorSensorIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid MachineSensorSensorId { get; set; }

        [Required(ErrorMessageResourceName = "ValueRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public required string Value { get; set; }
    }
    public class MachineSensorDataPutModel : BasePutModel
    {
        public Guid? MachineSensorMachineId { get; set; }
        public Guid? MachineSensorSensorId { get; set; }
        public string? Value { get; set; }
    }
    public class MachineSensorDataGetModel : BaseGetModel
    {
        public Guid? MachineSensorMachineId { get; set; }
        public Guid? MachineSensorSensorId { get; set; }
        public string? Value { get; set; }
    }
}
