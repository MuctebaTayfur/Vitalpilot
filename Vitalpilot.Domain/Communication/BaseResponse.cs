namespace Vitalpilot.Domain.Communication
{
    public class BaseResponse<TEntity> where TEntity : Base<TEntity>, IBase
    {
        public TEntity Entity { get; private set; }
        public bool Success { get; private set; }
        public string Message { get; private set; }

        public BaseResponse(TEntity entity)
        {
            this.Entity = entity;
            this.Success = true;
            this.Message = string.Empty;
        }

        public BaseResponse(string message)
        {
            this.Message = message;
            this.Success = false;
        }
    }
}