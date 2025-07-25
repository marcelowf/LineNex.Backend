
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class SensorRepository : BaseRepository<Sensor, SensorGetModel>, ISensorRepository
    {
        private readonly SqlContext sqlContext;
        public SensorRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
