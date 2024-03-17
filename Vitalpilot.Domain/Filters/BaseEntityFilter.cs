using System.Linq.Dynamic.Core;

namespace Vitalpilot.Domain.Filters
{
    public abstract class BaseEntityFilter<TEntity> : BaseFilter where TEntity : class, IBase
    {
        public virtual IQueryable<TEntity> Apply(IQueryable<TEntity> query)
        {
            query = query.Skip(this.Skip);

            query = query.Take(this.Take);

            if (!string.IsNullOrWhiteSpace(this.Predicate))
                query = query.Where(this.Predicate);

            if (!string.IsNullOrWhiteSpace(this.OrderBy))
                query = query.OrderBy(this.OrderBy);
            else
                query = query.OrderBy(p => p.CreatedDate);

            return query;
        }
    }
}