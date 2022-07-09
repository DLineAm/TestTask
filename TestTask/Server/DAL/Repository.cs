using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TestTask.Server.DAL.Context;

namespace TestTask.Server.DAL
{
    public interface IRepository<TEntity>
    {
         IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
    }
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal DatabaseContext Context;
        internal DbSet<TEntity> DbSet;

        public Repository(DatabaseContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        //params Expression<Func<TEntity, TProperty>>[] includeProperties

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var prop in includeProperties.Split(
                         new[]{','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(prop);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        private IQueryable<TEntity> Include<TProperty>(Expression<Func<TEntity, TProperty>>[] includeProperties)
        {
            IQueryable<TEntity> query = DbSet;
            return includeProperties
                .Aggregate(query, (curr, prop) => curr.Include(prop));
        }

        public virtual TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual TEntity GetByExpression(Expression<Func<TEntity, bool>> expression)
        {
            return DbSet.FirstOrDefault(expression);
        }

        public virtual TEntity GetLastByExpression(Expression<Func<TEntity, bool>> expression)
        {
            return DbSet.LastOrDefault(expression);
        }

        public virtual EntityEntry<TEntity> Insert(TEntity entity)
        {
            return DbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }

            DbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            if (Context.Entry(entityToUpdate).State == EntityState.Detached)
            {
                DbSet.Attach(entityToUpdate);
            }

            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

    }
}