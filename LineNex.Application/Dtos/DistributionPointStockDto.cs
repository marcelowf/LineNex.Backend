using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class DistributionPointStockDto : BaseDto
    {
        public string? ResourceName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Value { get; set; }
    }
}
