using System.Linq.Dynamic.Core;

namespace Vitalpilot.Domain.Filters
{
    public class EntityFilter<TEntity> : BaseEntityFilter<TEntity> where TEntity : class, IBase
    {
        public EntityFilter()
        {
        }
    }
}