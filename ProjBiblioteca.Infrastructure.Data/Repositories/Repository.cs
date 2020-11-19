  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected BibliotecaDBContext _context;
        public Repository(BibliotecaDBContext context)
        {
            _context = context;
        }

        void IRepository<T>.Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        void IRepository<T>.Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        System.Collections.Generic.IEnumerable<T> IRepository<T>.Get()
        {
            return _context.Set<T>().AsNoTracking();
        }

        T IRepository<T>.GetById(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }

        void IRepository<T>.Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
        }
    }
}