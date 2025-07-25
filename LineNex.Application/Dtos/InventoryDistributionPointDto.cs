using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class InventoryDistributionPointDto : BaseDto
    {
        public Guid InventoryId { get; set; }
        public Inventory? Inventory { get; set; }
        public Guid DistributionPointId { get; set; }
        public DistributionPoint? DistributionPoint { get; set; }
    }
}
