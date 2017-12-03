using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shine.Samples.NetCore.Domains.Aggregates;
using Shine.Samples.NetCore.IRepositories;

namespace Shine.Samples.NetCore.Repositories.EF
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : AggregateRoot
    {
        protected SampleDataContext _entities;
        protected readonly DbSet<T> _dbset;

        public GenericRepository(SampleDataContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
           
        }
        
        public T Get(object id)
        {
            return _dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {

            return _dbset.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual void Add(T entity)
        {
             _dbset.Add(entity);
        }

        public virtual void Delete(T entity)
        {
             _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }
    }
}
