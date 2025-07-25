using System.ComponentModel.DataAnnotations;

namespace LineNex.Core.Models
{
    public class BasePostModel { 
        [Required(ErrorMessageResourceName = "AuthorIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid AuthorId { get; set; }
    }

    public class BasePutModel
    {
        [Required(ErrorMessageResourceName = "AuthorIdRequiredValidation", ErrorMessageResourceType = typeof(LineNex.Specification.Resources.Messages))]
        public Guid AuthorId { get; set; }
    }

    public class BaseGetModel
    {
        public Guid? Id { get; set; }
        public Guid? CreatedById { get; set; }
        public Guid? ModifiedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
