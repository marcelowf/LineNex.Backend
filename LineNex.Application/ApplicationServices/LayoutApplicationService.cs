using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class LayoutApplicationService : BaseApplicationService<LayoutDto, LayoutPostModel, LayoutPutModel, LayoutGetModel, Layout>, ILayoutApplicationService
    {
        private readonly ILayoutService layoutService;

        public LayoutApplicationService(IMapper mapper, ILayoutService layoutService)
            : base(mapper, (IBaseService<Layout, LayoutGetModel>)layoutService)
        {
            this.layoutService = layoutService;
        }
    }
}
