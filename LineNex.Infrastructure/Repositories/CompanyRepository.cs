
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using LineNex.Infrastructure.Context;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class CompanyRepository : BaseRepository<Company, CompanyGetModel>, ICompanyRepository
    {
        private readonly SqlContext sqlContext;
        public CompanyRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
