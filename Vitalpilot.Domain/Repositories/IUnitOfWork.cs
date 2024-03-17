using Microsoft.EntityFrameworkCore.Storage;

namespace Vitalpilot.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();

        Task<int> SaveChangesAsync();
    }
}