
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class InventoryDistributionPointService : BaseService<InventoryDistributionPoint, InventoryDistributionPointGetModel>, IInventoryDistributionPointService
    {
        private readonly IInventoryDistributionPointRepository inventoryDistributionPointRepository;

        public InventoryDistributionPointService(IInventoryDistributionPointRepository inventoryDistributionPointRepository) : base(inventoryDistributionPointRepository)
        {
            this.inventoryDistributionPointRepository = inventoryDistributionPointRepository;
        }
    }
}