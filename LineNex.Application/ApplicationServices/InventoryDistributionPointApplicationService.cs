using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class InventoryDistributionPointApplicationService : BaseApplicationService<InventoryDistributionPointDto, InventoryDistributionPointPostModel, InventoryDistributionPointPutModel, InventoryDistributionPointGetModel, InventoryDistributionPoint>, IInventoryDistributionPointApplicationService
    {
        private readonly IInventoryDistributionPointService inventoryDistributionPointService;

        public InventoryDistributionPointApplicationService(IMapper mapper, IInventoryDistributionPointService inventoryDistributionPointService)
            : base(mapper, (IBaseService<InventoryDistributionPoint, InventoryDistributionPointGetModel>)inventoryDistributionPointService)
        {
            this.inventoryDistributionPointService = inventoryDistributionPointService;
        }
    }
}
