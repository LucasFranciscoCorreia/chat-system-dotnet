using Microsoft.Extensions.Logging;
using pitang.ons.treinamento.repositories.impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.repository.impl
{

    
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext _context;
        private readonly ILogger _logger;

        #region Repositories

        #endregion

        public UnitOfWork(DataContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ForceBeginTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void SetIsolationLevel(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }
    }
}
