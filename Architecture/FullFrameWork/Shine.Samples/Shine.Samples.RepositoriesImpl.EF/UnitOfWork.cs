using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shine.Samples.IRepositories;

namespace Shine.Samples.RepositoriesImpl.EF
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        
        private DbContext _dbContext;

        
        public UnitOfWork(DbContext context)
        {

            _dbContext = context;
        }
        
        
        public void  Commit()
        {
        
             _dbContext.SaveChanges();
        }

        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        private void Dispose(bool disposing)
        {
            if (disposing && _dbContext != null)
            {
                _dbContext.Dispose();
                _dbContext = null;
            }
        }
    }
}
