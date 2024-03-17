using Vitalpilot.Domain.Filters;

namespace Vitalpilot.Domain.Extensions
{
    public static class FilterExtensions
    {
        public static IQueryable<TEntity> ApplyFilter<TEntity>(this IQueryable<TEntity> query, BaseEntityFilter<TEntity> filter) where TEntity : class, IBase
        {
            query = filter.Apply(query);

            return query;
        }
    }
}