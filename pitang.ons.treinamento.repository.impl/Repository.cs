using Microsoft.EntityFrameworkCore;
using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.repositories;
using pitang.ons.treinamento.repositories.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.repository.impl
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected DataContext _context;
        protected DbSet<T> _entities;

        public Repository(DataContext dbContext)
        {
            _context = dbContext;
            //_context.Contacts.Include(x => x.Owner).First();
            //_context.Contacts.Include(x => x.ContactUser).First();
            _entities = _context.Set<T>();
        }
        public T Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public void Delete(T id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T>FindAll()
        {
            return _entities.AsEnumerable();
        }

        public Task<IEnumerable<T>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate).ToList<T>();
        }

        public void UnDelete(T id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
