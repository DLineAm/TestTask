using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using TestTask.Server.DAL.Context;

namespace TestTask.Server.DAL
{
    public sealed class Repository<TEntity> where TEntity : class
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        private IQueryable<TEntity> GetEntities(bool ignoreAutoInclude)
        {
            var query = ignoreAutoInclude
                ? _dbSet.IgnoreAutoIncludes()
                : _dbSet;

            return query;
        }

        /// <summary>
        /// Получение списка из бд
        /// </summary>
        /// <param name="filter">выражение фильтра</param>
        /// <param name="orderBy">функция сортировки</param>
        /// <returns></returns>
        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = GetEntities(true);

            return FilterAndOrderEntities(filter, orderBy, query);
        }

        /// <summary>
        /// Получение списка из бд с включенными внешними ключами
        /// </summary>
        /// <param name="filter">выражение фильтра</param>
        /// <param name="orderBy">функция сортировки</param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetWithChildren(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = GetEntities(false);

            return FilterAndOrderEntities(filter, orderBy, query);
        }

        private static IEnumerable<TEntity> FilterAndOrderEntities(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, IQueryable<TEntity> query)
        {
            if (filter != null)
            {
                query = query.Where(filter);
            }

            return orderBy != null
                ? orderBy(query).ToList()
                : query.ToList();
        }

        /// <summary>
        /// Получение записи из бд по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void DetachAllEntities()
        {
            var changedEntriesCopy = _context.ChangeTracker.Entries()
                .Where(e => e.Entity.GetType() == typeof(TEntity) &&(e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted ||
                            e.State == EntityState.Unchanged))
                .ToList();

            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }

        /// <summary>
        /// Добавление записи в бд
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntityEntry<TEntity> Insert(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        /// <summary>
        /// Удаление записи из бд
        /// </summary>
        /// <param name="entityToDelete"></param>
        public void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State is EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }


            _dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Изменение состояния записи из бд в измененное
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public void Update(TEntity entityToUpdate)
        {
            if (_context.Entry(entityToUpdate).State is EntityState.Detached)
            {
                _dbSet.Attach(entityToUpdate);
            }

            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

    }
}