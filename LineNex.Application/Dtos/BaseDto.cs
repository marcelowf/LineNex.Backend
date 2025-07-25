namespace LineNex.Application.Dtos
{
    public class BaseDto
    {
        public Guid? Id { get; set; }
        public Guid? CreatedById { get; set; }
        public Guid? ModifiedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
