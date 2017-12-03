using System;
using Microsoft.EntityFrameworkCore;
using Shine.Samples.NetCore.IRepositories.UOW;

namespace Shine.Samples.NetCore.Repositories.EF
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        
        private SampleDataContext _dbContext;

        
        public UnitOfWork(SampleDataContext context)
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
