using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.services.impl
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> contacts;

        public ContactService(IRepository<Contact> contacts)
        {
            this.contacts = contacts;
        }
        public Contact Add(Contact entity)
        {
            entity = contacts.Add(entity);
            return entity;
        }

        public Task<Contact> AddAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> FindAll()
        {
            return contacts.FindAll();
        }

        public Task<IEnumerable<Contact>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Contact> FindBy(Expression<Func<Contact, bool>> predicate)
        {
            return contacts.FindBy(predicate);
        }

        public void UnDelete(Contact id)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
