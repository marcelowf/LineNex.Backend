using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class UserDto : BaseDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public ICollection<UserCompany>? UserCompanies { get; set; }
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
