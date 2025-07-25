
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class ProductionLineMachineService : BaseService<ProductionLineMachine, ProductionLineMachineGetModel>, IProductionLineMachineService
    {
        private readonly IProductionLineMachineRepository productLineMachineRepository;

        public ProductionLineMachineService(IProductionLineMachineRepository productLineMachineRepository) : base(productLineMachineRepository)
        {
            this.productLineMachineRepository = productLineMachineRepository;
        }
    }
}