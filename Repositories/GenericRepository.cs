using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ComputerHardware.Models;
using ComputerHardware.Contracts;

namespace ComputerHardware.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Context _Context;

        public GenericRepository(Context Context)
        {
            _Context = Context;
        }

        public IQueryable<T> GetAll()
        {
            return this._Context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> Expression)
        {
            return this._Context.Set<T>().Where(Expression).AsNoTracking();
        }

        public void Create(T Entity)
        {
            this._Context.Set<T>().Add(Entity);
        }

        public void Update(T Entity)
        {
            this._Context.Set<T>().Update(Entity);
        }

        public void Delete(T Entity)
        {
            this._Context.Set<T>().Remove(Entity);
        }

        public async Task SaveAsync()
        {
            await this._Context.SaveChangesAsync();
        }
    }
}