using Microsoft.EntityFrameworkCore;
using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.repositories;
using pitang.ons.treinamento.repositories.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pitang.ons.treinamento.repository.impl
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext dbcontext) : base(dbcontext) { }

        public override IEnumerable<User> FindAll()
        {
            return _context.Users.AsQueryable().Include(e => e.Contacts).Select(e => e).ToList();
        }
    }
}
