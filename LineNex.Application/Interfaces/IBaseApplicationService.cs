using LineNex.Core.Models;

namespace LineNex.Application.Interfaces
{
    public interface IBaseApplicationService<TListDto, TPostDto, TPutDto, TGetDto>
        where TListDto : class
        where TPostDto : class
        where TPutDto : class
        where TGetDto : class
    {
        Task<PagedResult<TListDto>> GetAll(TGetDto filters, int pageIndex, int pageSize);
        Task<PagedResult<TListDto>> GetAllInclude(TGetDto filters, int pageIndex, int pageSize);
        Task<TListDto> Create(TPostDto entity);
        Task<TListDto> Update(Guid id, TPutDto entity);
        Task<bool> Delete(Guid id);
        Task<bool> SoftDelete(Guid id);
    }
}
