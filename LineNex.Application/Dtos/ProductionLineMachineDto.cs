using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class ProductionLineMachineDto : BaseDto
    {
        public Guid ProductionLineId { get; set; }
        public ProductionLine? ProductionLine { get; set; }
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
    }
}
