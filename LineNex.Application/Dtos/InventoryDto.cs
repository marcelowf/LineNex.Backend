using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class InventoryDto : BaseDto
    {
        public string? ResourceName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Value { get; set; }
        public ICollection<InventoryDistributionPoint>? InventoryDistributionPoints { get; set; }
    }
}
