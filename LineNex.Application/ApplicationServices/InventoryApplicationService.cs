using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class InventoryApplicationService : BaseApplicationService<InventoryDto, InventoryPostModel, InventoryPutModel, InventoryGetModel, Inventory>, IInventoryApplicationService
    {
        private readonly IInventoryService inventoryService;

        public InventoryApplicationService(IMapper mapper, IInventoryService inventoryService)
            : base(mapper, (IBaseService<Inventory, InventoryGetModel>)inventoryService)
        {
            this.inventoryService = inventoryService;
        }
    }
}
