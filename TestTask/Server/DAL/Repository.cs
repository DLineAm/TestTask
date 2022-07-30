using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using TestTask.Server.DAL.Context;

namespace TestTask.Server.DAL
{
    /// <summary>
    /// Реализация паттерна "Репозиторий" - промежуточный слой между моделью и остальной частью программмы 
    /// </summary>
    public sealed class Repository<TEntity> where TEntity : class, new()
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
        public IEnumerable<TEntity> GetWithChildren(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            var query = GetQuery(false);

            return FilterAndOrderEntities(filter, orderBy, query);
        }

        private IEnumerable<TEntity> FilterAndOrderEntities(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>
            , IOrderedQueryable<TEntity>> orderBy, IQueryable<TEntity> query)
        {
            if (filter != null)
                query = query.Where(filter);

            return orderBy != null
                ? orderBy(query).ToList()
                : query.ToList();
        }

        /// <summary>
        /// Получение записи из бд по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор требуемой записи</param>
        public TEntity Get(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(TEntity).Name} not found by Id={id}");
            }

            return entity;
        }

        /// <summary>
        /// Добавление записи в бд
        /// </summary>
        /// <param name="entity">Запись, которую нужно добавить в бд</param>
        public EntityEntry<TEntity> Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        /// <summary>
        /// Удаление записи из бд
        /// </summary>
        /// <param name="entityToDelete">Запись, которую нужно удалить</param>
        public void Delete(TEntity entityToDelete)
        {
            AttachEntity(entityToDelete);

            _dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Удаление записи из бд
        /// </summary>
        /// <param name="entityId">Идентификатор записи, которую нужно удалить</param>
        public void Delete(int entityId)
        {
            var entityToDelete = _dbSet.Find(entityId);

            AttachEntity(entityToDelete);

            _dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Удаление нескольких записей из бд
        /// </summary>
        /// <param name="entitiesToDelete">Записи, которые нужно удалить</param>
        public void DeleteBulk(IEnumerable<TEntity> entitiesToDelete)
        {
            _dbSet.RemoveRange(entitiesToDelete);
        }

        /// <summary>
        /// Изменение состояния записи из бд в измененное
        /// </summary>
        /// <param name="entityToUpdate">Запись, состояние которой нужно изменить</param>
        public void Update(TEntity entityToUpdate)
        {
            AttachEntity(entityToUpdate);
            _context.Update(entityToUpdate);

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