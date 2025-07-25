using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class ProductionLineMachineApplicationService : BaseApplicationService<ProductionLineMachineDto, ProductionLineMachinePostModel, ProductionLineMachinePutModel, ProductionLineMachineGetModel, ProductionLineMachine>, IProductionLineMachineApplicationService
    {
        private readonly IProductionLineMachineService productLineMachineService;

        public ProductionLineMachineApplicationService(IMapper mapper, IProductionLineMachineService productLineMachineService)
            : base(mapper, (IBaseService<ProductionLineMachine, ProductionLineMachineGetModel>)productLineMachineService)
        {
            this.productLineMachineService = productLineMachineService;
        }
    }
}
