using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PhoneDirectory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PhoneDirectory.Business.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext context;
        protected DbSet<T> db;

        public Repository(DbContext dbContext)
        {
            context = dbContext;
            db = context.Set<T>();
        }

        public void Remove(T entity)
        {
            db.Remove(entity);
        }

        public T GetById(Guid id)
        {
            return db.Find(id);
        }

        public List<T> GetList()
        {
            return db.ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> _lambdExpression)
        {
            return db.Where(_lambdExpression).ToList();
        }

        public void Add(T entity)
        {
            if (entity != null)
            {
                entity.CreatedOn = DateTime.Now;
                db.Add(entity);
            }
        }

        public void Update(T entity)
        {
            //TODO: [DEV] İlgili alanların güncellenemsi.
            var _entity = GetById(entity.Id);
            context.Entry(_entity).CurrentValues.SetValues(entity);
            _entity.UpdatedOn = DateTime.Now;
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
