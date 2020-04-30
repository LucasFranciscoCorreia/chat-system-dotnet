using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.repositories;
using pitang.ons.treinamento.repositories.impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace pitang.ons.treinamento.repository.impl
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
