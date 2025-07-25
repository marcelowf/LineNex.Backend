using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class ProductionLineApplicationService : BaseApplicationService<ProductionLineDto, ProductionLinePostModel, ProductionLinePutModel, ProductionLineGetModel, ProductionLine>, IProductionLineApplicationService
    {
        private readonly IProductionLineService productLineService;

        public ProductionLineApplicationService(IMapper mapper, IProductionLineService productLineService)
            : base(mapper, (IBaseService<ProductionLine, ProductionLineGetModel>)productLineService)
        {
            this.productLineService = productLineService;
        }
    }
}
