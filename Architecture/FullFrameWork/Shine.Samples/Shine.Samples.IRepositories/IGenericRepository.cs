using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Shine.Samples.Domains.Aggregates;

namespace Shine.Samples.IRepositories
{
    public interface IGenericRepository<T> where T : AggregateRoot
    {
        T Get(object id);
       
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        
    }

}
