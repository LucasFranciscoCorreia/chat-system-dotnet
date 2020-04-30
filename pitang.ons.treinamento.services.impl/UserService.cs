using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.services.impl
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> users;

        public UserService(IRepository<User> users) {
            this.users = users;
        }

        public User Add(User entity)
        {
            entity = users.Add(entity);
            return entity;
        }

        public async Task<User> AddAsync(User entity)
        {
            return await users.AddAsync(entity);
        }

        public void Delete(User id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindAll()
        {
            return users.FindAll();
        }

        public Task<IEnumerable<User>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<User> FindBy(Expression<Func<User, bool>> predicate)
        {
            return this.users.FindBy(predicate);
        }

        public void UnDelete(User id)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
