using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class MachineConnectionPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "ConnectedMachineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid ConnectedMachineId { get; set; }
    }
    public class MachineConnectionPutModel : BasePutModel
    {
        public Guid? ConnectedMachineId { get; set; }
    }
    public class MachineConnectionGetModel : BaseGetModel
    {
        public Guid? ConnectedMachineId { get; set; }
    }
}
