
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Service.Interfaces;
using LineNex.Core.Models;

namespace LineNex.Service.Services
{
    public class TagService : BaseService<Tag, TagGetModel>, ITagService
    {
        private readonly ITagRepository tagRepository;

        public TagService(ITagRepository tagRepository) : base(tagRepository)
        {
            this.tagRepository = tagRepository;
        }
    }
}