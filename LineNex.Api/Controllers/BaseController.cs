using LineNex.Api.ExceptionHendler;
using LineNex.Api.ExceptionModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Base controller providing generic CRUD operations for entities.
    /// </summary>
    /// <typeparam name="TDTO">DTO type for listing entities.</typeparam>
    /// <typeparam name="TPostModel">DTO type for creating or updating entities.</typeparam>
    /// <typeparam name="TService">Service type handling entity operations.</typeparam>
    /// <typeparam name="TGetModel">Filter type for querying entities.</typeparam>
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public abstract class BaseController<TDTO, TPostModel, TPutModel, TService, TGetModel> : ControllerBase
        where TDTO : class
        where TPostModel : class
        where TPutModel : class
        where TService : class
        where TGetModel : class
    {
        /// <summary>
        /// The service instance used to perform operations on the entity.
        /// </summary>
        protected readonly TService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController{TDTO, TPostModel, TService, TGetModel}"/> class.
        /// </summary>
        /// <param name="service">The service instance.</param>
        protected BaseController(TService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves all entities based on provided filters.
        /// </summary>
        /// <param name="filters">Filters for querying entities.</param>
        /// <param name="pageIndex">Page Index</param>
        /// <param name="pageSize">Page Size</param>
        /// <returns>A list of entities.</returns>
        [HttpGet]
        [Authorize(Policy = "Permission.Reader")]
        public virtual async Task<IActionResult> GetAll([FromQuery] TGetModel filters, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 20)
        {
            var pagedDto = await (service as dynamic).GetAll(filters, pageIndex, pageSize);

            if (pagedDto.Items == null || pagedDto.Items.Count == 0)
                throw new NotFoundException("No entities found with the given filters.");

            return Ok(pagedDto);
        }

        /// <summary>
        /// Retrieves all entities with includes based on provided filters.
        /// </summary>
        /// <param name="filters">Filters for querying entities.</param>
        /// <param name="pageIndex">Page Index</param>
        /// <param name="pageSize">Page Size</param>
        /// <returns>A list of entities.</returns>
        [HttpGet("GetAllInclude")]
        [Authorize(Policy = "Permission.Reader")]
        public virtual async Task<IActionResult> GetAllInclude([FromQuery] TGetModel filters, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 20)
        {
            var pagedDto = await (service as dynamic).GetAllInclude(filters, pageIndex, pageSize);

            if (pagedDto.Items == null || pagedDto.Items.Count == 0)
                throw new NotFoundException("No entities found with the given filters.");

            return Ok(pagedDto);
        }

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="dto">The data for creating the entity.</param>
        /// <returns>The created entity.</returns>
        [HttpPost]
        [ValidateAtrributes]
        [Authorize(Policy = "Permission.Create")]
        public virtual async Task<IActionResult> Create([FromBody] TPostModel dto)
        {
            if (!ModelState.IsValid)
                throw new BadRequestException("Invalid data provided.");

            var result = await (service as dynamic).Create(dto);
            return CreatedAtAction(nameof(GetAll), new { id = (result as dynamic).Id }, result);
        }

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to update.</param>
        /// <param name="dto">The updated data.</param>
        /// <returns>NoContent if successful; otherwise, appropriate error response.</returns>
        [HttpPut("{id}")]
        [Authorize(Policy = "Permission.Update")]
        public virtual async Task<IActionResult> Update(Guid id, [FromBody] TPutModel dto)
        {
            if (!ModelState.IsValid)
                throw new BadRequestException("Invalid data provided.");

            var result = await (service as dynamic).Update(id, dto);
            if (result == null)
                throw new NotFoundException($"Entity with ID {id} not found.");

            return Ok(result);
        }

        /// <summary>
        /// Deletes an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to delete.</param>
        /// <returns>NoContent if successful; otherwise, NotFound.</returns>
        [HttpDelete("{id}")]
        [Authorize(Policy = "Permission.Delete")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            var result = await (service as dynamic).Delete(id);
            if (!result)
                throw new NotFoundException($"Entity with ID {id} not found or already deleted.");

            return Ok(new { message = "Entity deleted successfully" });
        }

        /// <summary>
        /// Performs a soft delete on an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to soft delete.</param>
        /// <returns>NoContent if successful; otherwise, NotFound.</returns>
        [HttpPatch("SoftDelete/{id}")]
        [Authorize(Policy = "Permission.Update")]
        public virtual async Task<IActionResult> SoftDelete(Guid id)
        {
            var result = await (service as dynamic).SoftDelete(id);
            if (!result)
                throw new NotFoundException($"Entity with ID {id} not found or already soft deleted.");

            return Ok(new { message = "Entity soft deleted successfully" });
        }
    }
}
