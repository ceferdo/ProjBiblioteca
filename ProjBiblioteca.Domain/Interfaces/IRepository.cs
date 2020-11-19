using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IRepository<T>
    {
         IEnumerable<T> Get();

         T GetById(Expression<Func<T, bool>> predicate);

         void Add(T entity);

         void Update(T entity);

         void Delete(T entity);
    }
}