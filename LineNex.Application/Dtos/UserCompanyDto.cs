using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class UserCompanyDto : BaseDto
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
