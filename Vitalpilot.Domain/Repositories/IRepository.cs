using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Filters;

namespace Vitalpilot.Domain.Repositories
{
    public interface IRepository<T> where T : IBase
    {
        /// <summary>
        /// Adds a single entity to the repository.
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Adds a collection of entities to the repository.
        /// </summary>
        /// <param name="entities"></param>
        void AddRange(IEnumerable<T> entities);

        /// <summary>
        /// Updates the specified entity in the repository.
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Updates a collection of entities in the repository.
        /// </summary>
        /// <param name="entities"></param>
        void UpdateRange(IEnumerable<T> entities);

        /// <summary>
        /// Marks the specified entity for soft deletion in the repository.
        /// </summary>
        /// <param name="entity"></param>
        void SoftDelete(T entity);

        /// <summary>
        /// Marks a collection of entities for soft deletion in the repository. Similar to SoftDelete(T entity), this method applies soft deletion to multiple entities at once.
        /// </summary>
        /// <param name="entities"></param>
        void SoftDeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// Lists an entites from database with query filter.
        /// </summary>
        /// <param name="filter">Query filter</param>
        /// <returns></returns>
        Task<IEnumerable<T>> ListAsync(BaseFilter filter);

        /// <summary>
        /// Finds an entity with primary key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        ValueTask<T?> FindAsync(object key);

        /// <summary>
        /// Gets an entity from database with unique id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T?> GetAsync(Guid id);

        /// <summary>
        /// Get an entity from database with unique id and defined includes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        Task<T?> GetAsync(Guid id, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets all records with AsNoTracking.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> AllAsNoTracking();

        /// <summary>
        /// Gets all records.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> All();

        /// <summary>
        /// Gets all records with with includes
        /// </summary>
        /// <param name="includes">Entities to include</param>
        /// <returns></returns>
        IQueryable<T> All(params Expression<Func<T, object>>[] includes);

        Task<int> GetTotalCountAsync(BaseFilter filter);
    }
}