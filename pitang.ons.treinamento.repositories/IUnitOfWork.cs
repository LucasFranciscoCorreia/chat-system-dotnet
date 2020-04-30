using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace pitang.ons.treinamento.repository.impl
{
    public interface IUnitOfWork
    {
        #region Repositories

        #endregion
        void ForceBeginTransaction();
        Task CommitAsync();
        void Commit();
        Task<int> SaveChangesAsync();
        void SetIsolationLevel(IsolationLevel isolationLevel);

        void Dispose();
    }
}
