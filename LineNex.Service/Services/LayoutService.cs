
using LineNex.Core.Models;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class LayoutService : BaseService<Layout, LayoutGetModel>, ILayoutService
    {
        private readonly ILayoutRepository layoutRepository;

        public LayoutService(ILayoutRepository layoutRepository) : base(layoutRepository)
        {
            this.layoutRepository = layoutRepository;
        }
    }
}