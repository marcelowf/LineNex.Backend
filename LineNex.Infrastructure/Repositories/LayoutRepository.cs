
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class LayoutRepository : BaseRepository<Layout, LayoutGetModel>, ILayoutRepository
    {
        private readonly SqlContext sqlContext;
        public LayoutRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
