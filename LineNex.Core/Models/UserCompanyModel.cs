using System.ComponentModel.DataAnnotations;
using static LineNex.Specification.Resources.Messages;

namespace LineNex.Core.Models
{
    public class UserCompanyPostModel : BasePostModel
    {
        [Required(ErrorMessageResourceName = "UserIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid UserId { get; set; }

        [Required(ErrorMessageResourceName = "CompanyIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid CompanyId { get; set; }
    }
    public class UserCompanyPutModel : BasePutModel
    {
        public Guid? UserId { get; set; }
        public Guid? CompanyId { get; set; }
    }
    public class UserCompanyGetModel : BaseGetModel
    {
        public Guid? UserId { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
