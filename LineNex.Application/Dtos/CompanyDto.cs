using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class CompanyDto : BaseDto
    {
        public string? Name { get; set; }
        public ICollection<UserCompany>? UserCompanies { get; set; }
        public ICollection<ProductionLine>? ProductionLines { get; set; }
    }
}
