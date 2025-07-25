using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface ITagApplicationService : IBaseApplicationService<TagDto, TagPostModel, TagPutModel, TagGetModel>
    {
    }
}
