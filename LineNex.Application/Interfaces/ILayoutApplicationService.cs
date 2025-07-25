using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface ILayoutApplicationService : IBaseApplicationService<LayoutDto, LayoutPostModel, LayoutPutModel, LayoutGetModel>
    {
    }
}
