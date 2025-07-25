using LineNex.Domain.Entity;

namespace LineNex.Application.Dtos
{
    public class DistributionPointDto : BaseDto
    {
        public string? Name { get; set; }
        public ICollection<DistributionPointMachine>? DistributionPointMachines { get; set; }
        public ICollection<DistributionPointStock>? DistributionPointStocks { get; set; }
        public ICollection<InventoryDistributionPoint>? InventoryDistributionPoints { get; set; }
    }
}
