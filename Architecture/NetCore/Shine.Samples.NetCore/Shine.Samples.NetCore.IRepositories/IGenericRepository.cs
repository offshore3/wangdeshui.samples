

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shine.Samples.NetCore.Domains.Aggregates;

namespace Shine.Samples.NetCore.IRepositories
{
    public interface IGenericRepository<T> where T : AggregateRoot
    {
        T Get(object id);
       
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        
    }

}
