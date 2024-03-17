using Vitalpilot.Domain.Communication;
using Vitalpilot.Domain.Filters;

namespace Vitalpilot.Domain.Services
{
    public interface IService<TEntity, TRepository, TResponse>
        where TEntity : Base<TEntity>, IBase
        where TResponse : BaseResponse<TEntity>
    {
        Task<TResponse> CreateAsync(TEntity entity);

        Task<TResponse> UpdateAsync(Guid id, TEntity entity);

        Task<TResponse> DeleteAsync(Guid id);
    }
}