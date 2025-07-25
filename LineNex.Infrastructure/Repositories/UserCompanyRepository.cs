
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class UserCompanyRepository : BaseRepository<UserCompany, UserCompanyGetModel>, IUserCompanyRepository
    {
        private readonly SqlContext sqlContext;
        public UserCompanyRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
