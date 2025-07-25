
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class MachineTagRepository : BaseRepository<MachineTag, MachineTagGetModel>, IMachineTagRepository
    {
        private readonly SqlContext sqlContext;
        public MachineTagRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
