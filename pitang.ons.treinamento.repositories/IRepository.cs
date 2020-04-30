using pitang.ons.treinamento.entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Delete(T id);
        void UnDelete(T id);
        IEnumerable<T> FindAll();
        Task<IEnumerable<T>> FindAllAsync();
        IList<T> FindBy(Expression<Func<T, bool>> predicate);

    }
}
