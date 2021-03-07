using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PhoneDirectory.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        List<T> GetList();
        List<T> GetList(Expression<Func<T, bool>> _lambdExpression);
        T GetById(Guid id);
    }
}
