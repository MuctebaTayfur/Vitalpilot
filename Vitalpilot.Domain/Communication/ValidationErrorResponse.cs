namespace Vitalpilot.Domain.Communication
{
    public class ValidationErrorResponse<TEntity> : BaseResponse<TEntity> where TEntity : Base<TEntity>, IBase
    {
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> ValidationErrors { get; private set; }

        public ValidationErrorResponse(IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> validationErrors) : base("One or more validation errors occurred.")
        {
            this.ValidationErrors = validationErrors;
        }
    }
}