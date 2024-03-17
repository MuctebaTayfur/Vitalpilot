using FluentValidation;
using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain;
using Vitalpilot.Domain.Communication;
using Vitalpilot.Domain.Repositories;
using Vitalpilot.Domain.Services;

namespace Vitalpilot.Services
{
    public class Service<TEntity, TRepository, TResponse> : IService<TEntity, TRepository, TResponse>
        where TEntity : Base<TEntity>, IBase
        where TResponse : BaseResponse<TEntity>
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidatorFactory _validatorFactory;

        public Service(IRepository<TEntity> repository,
            IUnitOfWork unitOfWork,
            IValidatorFactory validatorFactory)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _validatorFactory = validatorFactory;
        }

        internal static TResponse CreateErrorResponse(string errorMessage)
        {
            return new BaseResponse<TEntity>(errorMessage) as TResponse;
        }

        internal static TResponse CreateValidationErrorResponse(IEnumerable<ValidationResult> errors)
        {
            return new ValidationErrorResponse<TEntity>(errors) as TResponse;
        }

        internal static TResponse CreateResponse(TEntity entity)
        {
            return new BaseResponse<TEntity>(entity) as TResponse;
        }

        internal async Task<IEnumerable<ValidationResult>> Validate(TEntity entity)
        {
            ValidationContext context = new ValidationContext(entity);

            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(entity, context, results))
                return results;
            else
            {
                var validator = _validatorFactory.GetValidator<TEntity>();

                if (validator == null)
                    return results;

                var validationResult = await validator.ValidateAsync(entity);

                foreach (var error in validationResult.Errors)
                    results.Add(new ValidationResult(error.ErrorMessage, new string[] { error.PropertyName }));

                return results;
            }
        }

        public virtual async Task<TResponse> CreateAsync(TEntity entity)
        {
            entity = entity.CreateNew();

            var validationResults = await Validate(entity);
            if (validationResults.Any())
                return CreateValidationErrorResponse(validationResults);

            _repository.Add(entity);

            await _unitOfWork.SaveChangesAsync();

            return CreateResponse(entity);
        }

        public virtual async Task<TResponse> UpdateAsync(Guid id, TEntity entity)
        {
            var existingEntity = await _repository.GetAsync(id);

            if (existingEntity == null)
                return CreateErrorResponse("Invalid id");

            var validationResults = await Validate(existingEntity);
            if (validationResults.Any())
                return CreateValidationErrorResponse(validationResults);

            _repository.Update(existingEntity);

            await _unitOfWork.SaveChangesAsync();

            return CreateResponse(entity);
        }

        public virtual async Task<TResponse> DeleteAsync(Guid id)
        {
            var existingEntity = await _repository.GetAsync(id);

            if (existingEntity == null)
                return CreateErrorResponse("Invalid id");

            existingEntity.Delete();

            _repository.Update(existingEntity);

            await _unitOfWork.SaveChangesAsync();

            return CreateResponse(existingEntity);
        }
    }
}