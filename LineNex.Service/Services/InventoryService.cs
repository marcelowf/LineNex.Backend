
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class InventoryService : BaseService<Inventory, InventoryGetModel>, IInventoryService
    {
        private readonly IInventoryRepository inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository) : base(inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
    }
}