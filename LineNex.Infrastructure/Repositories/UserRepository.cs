
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User, UserGetModel>, IUserRepository
    {
        private readonly SqlContext sqlContext;
        public UserRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
