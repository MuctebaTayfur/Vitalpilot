using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Vitalpilot.Domain;
using Vitalpilot.Domain.Extensions;
using Vitalpilot.Domain.Filters;
using Vitalpilot.Domain.Repositories;
using Vitalpilot.EntityFramework.Context;

namespace Vitalpilot.EntityFramework.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IBase
    {
        protected readonly VitalpilotDbContext Context;

        public Repository(VitalpilotDbContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> All()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public IQueryable<TEntity> AllAsNoTracking()
        {
            return Context.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> All(params Expression<Func<TEntity, object>>[] includes)
        {
            var baseQuery = Context.Set<TEntity>().AsQueryable();

            foreach (var include in includes)
                baseQuery = baseQuery.Include(include);

            return baseQuery;
        }

        public async ValueTask<TEntity?> FindAsync(object key)
        {
            return await Context.Set<TEntity>().FindAsync(key);
        }

        public async Task<TEntity?> GetAsync(Guid id)
        {
            return await Context.Set<TEntity>().SingleOrDefaultAsync(x => x.UniqueId == id);
        }

        public async Task<TEntity?> GetAsync(Guid id, params Expression<Func<TEntity, object>>[] includes)
        {
            var baseQuery = Context.Set<TEntity>().AsQueryable();

            foreach (var include in includes)
                baseQuery = baseQuery.Include(include);

            return await baseQuery.SingleOrDefaultAsync(a => a.UniqueId == id);
        }

        public virtual void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            TEntity existingEntity = Context.Set<TEntity>().Find(entity.UniqueId);

            if (existingEntity == null)
                throw new DbUpdateException($"Entity with unique id '{entity.UniqueId}' not found.");

            Context.Entry(existingEntity).CurrentValues.SetValues(entity);
        }

        public virtual void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                this.Update(entity);
        }

        public virtual void SoftDelete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public virtual void SoftDeleteRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public virtual async Task<IEnumerable<TEntity>> ListAsync(BaseEntityFilter<TEntity> filter)
        {
            return await Context.Set<TEntity>()
                .ApplyFilter(filter)
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<int> GetTotalCountAsync(BaseEntityFilter<TEntity> filter)
        {
            return await Context.Set<TEntity>()
                .ApplyFilter(filter)
                .AsNoTracking()
                .CountAsync();
        }
    }
}