using System;
using System.Linq;
using System.Linq.Expressions;

namespace Abarnathy.DemographicsAPI.Repositories
{
    /// <summary>
    /// Provides generic base repository functionality.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}