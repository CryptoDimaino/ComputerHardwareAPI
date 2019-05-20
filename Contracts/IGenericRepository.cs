using System;  
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Linq.Expressions;  
using System.Threading.Tasks; 

namespace ComputerHardware.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> Expression);
        void Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        Task SaveAsync();
    }
}