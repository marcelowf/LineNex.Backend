
using LineNex.Core.Interfaces;
using LineNex.Core.Models;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;

namespace LineNex.Infrastructure.Repositories
{
    public class TagRepository : BaseRepository<Tag, TagGetModel>, ITagRepository
    {
        private readonly SqlContext sqlContext;
        public TagRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
