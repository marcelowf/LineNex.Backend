using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class MachineTagPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "MachineIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid MachineId { get; set; }
        
        [Required(ErrorMessageResourceName = "TagIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid TagId { get; set; }
    }
    public class MachineTagPutModel : BasePutModel
    {
        public Guid? MachineId { get; set; }
        public Guid? TagId { get; set; }
    }
    public class MachineTagGetModel : BaseGetModel
    {
        public Guid? MachineId { get; set; }
        public Guid? TagId { get; set; }
    }
}
