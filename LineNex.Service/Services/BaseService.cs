using LineNex.Core.Interfaces;
using LineNex.Core.Models;
using LineNex.Service.Interfaces;

namespace LineNex.Service.Services
{
    public class BaseService<TEntity, TFilters> : IBaseService<TEntity, TFilters>
        where TEntity : class
        where TFilters : class
    {
        private readonly IBaseRepository<TEntity, TFilters> repository;

        public BaseService(IBaseRepository<TEntity, TFilters> repository)
        {
            this.repository = repository;
        }

        public async Task<PagedResult<TEntity>> GetAll(TFilters filters, int pageIndex, int pageSize)
        {
            return await repository.GetAll(filters, pageIndex, pageSize);
        }

        public async Task<PagedResult<TEntity>> GetAllInclude(TFilters filters, int pageIndex, int pageSize)
        {
            return await repository.GetAllInclude(filters, pageIndex, pageSize);
        }

        public async Task<TEntity> Create(Guid authorId, TEntity entity)
        {
            return await repository.Create(authorId, entity);
        }

        public async Task<TEntity> Update(Guid authorId, Guid id, TEntity entity)
        {
            return await repository.Update(authorId, id, entity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await repository.Delete(id);
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            return await repository.SoftDelete(id);
        }
    }
}
