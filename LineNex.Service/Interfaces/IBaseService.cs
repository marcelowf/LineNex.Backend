using LineNex.Core.Models;

namespace LineNex.Service.Interfaces
{
    public interface IBaseService<TEntity, TFilters> where TEntity : class
    {
        Task<PagedResult<TEntity>> GetAll(TFilters filters, int pageIndex, int pageSize);
        Task<PagedResult<TEntity>> GetAllInclude(TFilters filters, int pageIndex, int pageSize);
        Task<TEntity> Create(Guid authorId, TEntity entity);
        Task<TEntity> Update(Guid authorId, Guid id, TEntity entity);
        Task<bool> Delete(Guid id);
        Task<bool> SoftDelete(Guid id);
    }
}
