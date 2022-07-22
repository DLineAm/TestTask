using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using TestTask.Server.DAL.Context;
using TestTask.Shared;

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

        private IQueryable<TEntity> GetQuery(bool ignoreAutoInclude)
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
            var query = GetQuery(true);

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
            var query = GetQuery(false);

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
        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Добавление записи в бд
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntityEntry<TEntity> Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        /// <summary>
        /// Удаление записи из бд
        /// </summary>
        /// <param name="entityToDelete"></param>
        public void Delete(TEntity entityToDelete)
        {
            AttachEntity(entityToDelete);

            _dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Изменение состояния записи из бд в измененное
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public void Update(TEntity entityToUpdate)
        {
            AttachEntity(entityToUpdate);
            _context.Update(entityToUpdate);
            //_context.Entry(entityToUpdate).State = EntityState.Modified;

            _context.SaveChanges();
        }

        private void AttachEntity(TEntity entity)
        {
            if (_context.Entry(entity).State is EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
        }
    }
}