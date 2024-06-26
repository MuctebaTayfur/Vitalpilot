using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vitalpilot.Domain;
using Vitalpilot.Domain.Communication;
using Vitalpilot.Domain.Dtos;
using Vitalpilot.Domain.Dtos.Interfaces;
using Vitalpilot.Domain.Filters;
using Vitalpilot.Domain.Filters.Interfaces;
using Vitalpilot.Domain.Models;
using Vitalpilot.Domain.Repositories;
using Vitalpilot.Domain.Services;

namespace Vitalpilot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseEntityController<TEntity, TResource, TFilter> : ControllerBase
        where TEntity : Base<TEntity>, IBase
        where TResource : IDto
        where TFilter : BaseEntityFilter<TEntity>
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IService<TEntity, IRepository<TEntity>, BaseResponse<TEntity>> _service;
        private readonly IMapper _mapper;

        public BaseEntityController(IRepository<TEntity> repository, IService<TEntity, IRepository<TEntity>, BaseResponse<TEntity>> service, IMapper mapper)
        {
            _service = service;
            _repository = repository;
            _mapper = mapper;
        }

        internal Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary CreateModelStateErrors(BaseResponse<TEntity> response)
        {
            if (response is ValidationErrorResponse<TEntity> errorResponse &&
                errorResponse.ValidationErrors != null &&
                errorResponse.ValidationErrors.Any())
            {
                foreach (var error in errorResponse.ValidationErrors)
                    ModelState.AddModelError(error.MemberNames.FirstOrDefault(), error.ErrorMessage);
            }
            else
                ModelState.AddModelError(String.Empty, response.Message.ToString());

            return ModelState;
        }

        /// <summary>
        ///  Lists filtered all entities
        /// </summary>
        /// <returns>List of entities.</returns>
        /// <response code="200">Returns the list of entities</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<ActionResult<FilteredResponse<TResource, TFilter>>> ListAsync([FromQuery] TFilter filter)
        {
            var entities = await _repository.ListAsync(filter);

            var resources = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TResource>>(entities);
            var filteredRespose = new FilteredResponse<TResource, TFilter>()
            {
                Data = resources,
                Filter = filter,
                DataCount = resources.Count(),
                TotalCount = await _repository.GetTotalCountAsync(filter)
            };

            return Ok(filteredRespose);
        }

        /// <summary>
        /// Gets the entity by identifier
        /// </summary>
        /// <param name="id">Guid of the entity</param>
        /// <returns>Entity</returns>
        /// <response code="200">Returns the selected entity</response>
        /// <response code="400">If the entity is null</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public virtual async Task<ActionResult<TResource>> GetAsync(Guid id)
        {
            var entity = await _repository.GetAsync(id);

            if (entity == null)
                return NotFound();

            var resource = _mapper.Map<TEntity, TResource>(entity);

            return Ok(resource);
        }

        /// <summary>
        /// Creates a new entity
        /// </summary>
        /// <param name="resource">Entity data</param>
        /// <returns>Entity</returns>
        /// <response code="201">Returns the newly created entity</response>
        /// <response code="400">If error occured</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public virtual async Task<ActionResult<TResource>> PostAsync([FromBody] TResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entity = _mapper.Map<TResource, TEntity>(resource);
            var result = await _service.CreateAsync(entity);

            if (!result.Success)
                return BadRequest(CreateModelStateErrors(result));

            var entityResource = _mapper.Map<TEntity, TResource>(result.Entity);

            return CreatedAtAction("Get", new { id = result.Entity.UniqueId }, entityResource);
        }

        /// <summary>
        /// Deletes an entity by identifier
        /// </summary>
        /// <param name="id">Entity identifier</param>
        /// <returns>No content</returns>
        /// <response code="204">Deletes entity</response>
        /// <response code="400">If error occured</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public virtual async Task<IActionResult> DeleteAsync(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(CreateModelStateErrors(result));

            return NoContent();
        }
    }
}