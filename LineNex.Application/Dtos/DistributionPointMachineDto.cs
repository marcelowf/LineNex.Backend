using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class DistributionPointMachineDto : BaseDto
    {
        public Guid DistributionPointId { get; set; }
        public DistributionPoint? DistributionPoint { get; set; }
        public Guid MachineId { get; set; }
        public Machine? Machine { get; set; }
    }
}
