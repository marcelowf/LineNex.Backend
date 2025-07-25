using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineNex.Domain.Entity
{
    public class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public required Guid? CreatedById { get; set; }
        public Guid? ModifiedById { get; set; }

        [DataType(DataType.DateTime)]
        public required DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedAt { get; set; }
        public required bool IsDeleted { get; set; }
    }
}