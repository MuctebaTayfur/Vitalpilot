using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Vitalpilot.Domain.Repositories;
using Vitalpilot.EntityFramework.Context;

namespace Vitalpilot.EntityFramework.Repositories
{
    public class UnitOFWork : IUnitOfWork, IDisposable
    {
        private bool _disposed;
        private readonly VitalpilotDbContext _context;

        public UnitOFWork(VitalpilotDbContext context)
        {
            _context = context;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        protected void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}