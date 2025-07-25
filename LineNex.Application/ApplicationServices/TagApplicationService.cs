using AutoMapper;

using LineNex.Application.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Applications
{
    public class TagApplicationService : BaseApplicationService<TagDto, TagPostModel, TagPutModel, TagGetModel, Tag>, ITagApplicationService
    {
        private readonly ITagService tagService;

        public TagApplicationService(IMapper mapper, ITagService tagService)
            : base(mapper, (IBaseService<Tag, TagGetModel>)tagService)
        {
            this.tagService = tagService;
        }
    }
}
