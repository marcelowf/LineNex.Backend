using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class ProductionLineDto : BaseDto
    {
        public string? Name { get; set; }
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
        public ICollection<ProductionLineMachine>? ProductionLineMachines { get; set; }
    }
}
