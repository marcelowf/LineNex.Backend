using AutoMapper;
using LineNex.Application.Interfaces;
using LineNex.Core.Models;
using LineNex.Service.Interfaces;

namespace LineNex.Application.Applications
{
    public abstract class BaseApplicationService<TListDto, TPostDto, TPutDto, TGetDto, TEntity> : IBaseApplicationService<TListDto, TPostDto, TPutDto, TGetDto>
        where TListDto : class
        where TPostDto : class
        where TPutDto : class
        where TGetDto : class
        where TEntity : class
    {
        private readonly IMapper mapper;
        private readonly IBaseService<TEntity, TGetDto> baseService;

        protected BaseApplicationService(IMapper mapper, IBaseService<TEntity, TGetDto> baseService)
        {
            this.mapper = mapper;
            this.baseService = baseService;
        }

        public async Task<PagedResult<TListDto>> GetAll(TGetDto filters, int pageIndex, int pageSize)
        {
            var paged = await this.baseService.GetAll(filters, pageIndex, pageSize);
            var dtos = mapper.Map<IList<TListDto>>(paged.Items);
            return new PagedResult<TListDto>
            {
                Items = dtos,
                TotalCount = paged.TotalCount,
                PageIndex = paged.PageIndex,
                PageSize = paged.PageSize
            };
        }

        public async Task<PagedResult<TListDto>> GetAllInclude(TGetDto filters, int pageIndex, int pageSize)
        {
            var paged = await this.baseService.GetAllInclude(filters, pageIndex, pageSize);
            var dtos = mapper.Map<IList<TListDto>>(paged.Items);
            return new PagedResult<TListDto>
            {
                Items = dtos,
                TotalCount = paged.TotalCount,
                PageIndex = paged.PageIndex,
                PageSize = paged.PageSize
            };
        }

        public async Task<TListDto> Create(TPostDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);
            var createdEntity = await this.baseService.Create((Guid)typeof(TPostDto).GetProperty("AuthorId").GetValue(dto), entity);
            return this.mapper.Map<TListDto>(createdEntity);
        }

        public async Task<TListDto> Update(Guid id, TPutDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);
            var updatedEntity = await this.baseService.Update((Guid)typeof(TPutDto).GetProperty("AuthorId").GetValue(dto), id, entity);
            return this.mapper.Map<TListDto>(updatedEntity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await this.baseService.Delete(id);
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            return await this.baseService.SoftDelete(id);
        }
    }
}
