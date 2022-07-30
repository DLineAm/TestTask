using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using TestTask.Shared;

namespace TestTask.Server.Storage
{
    /// <summary>
    /// Промежуточное хранилище с возможностью чтения и записи данных
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class CacheStorage<TEntity> : IStorage<TEntity> where TEntity : IIdentity, new()
    {
        private ConcurrentDictionary<int, TEntity> _storage = new ConcurrentDictionary<int, TEntity>();

        /// <summary>
        /// Получение списка записей
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        public IEnumerable<TEntity> GetAll(Func<TEntity, bool> filter = null)
        {
            var list = _storage.Select(e => e.Value);

            if (filter != null)
                list = list.Where(filter);

            return list;
        }

        /// <summary>
        /// Получение записи по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор нужной записи</param>
        public TEntity Get(int id)
        {
            if (!_storage.TryGetValue(id, out var value))
                throw new ArgumentException($"{typeof(TEntity).Name} not found by Id={id}");

            return value;
        }

        /// <summary>
        /// Получение первой подходящей записи по выражению
        /// </summary>
        /// <param name="expression">Выражение, с помощью которого нужно найти первую подходящую запись</param>
        public TEntity Get(Func<TEntity, bool> expression)
        {
            return _storage.Select(e => e.Value).FirstOrDefault(expression);
        }

        /// <summary>
        /// Заполнение промежуточного хранилища с помощью списка записей
        /// </summary>
        /// <param name="entities">Список записей, требуемый для заполнения промежуточного хранилища</param>
        public void Fill(IEnumerable<TEntity> entities)
        {
            _storage.Clear();

            var keyValues = entities.Select(x => new KeyValuePair<int, TEntity>(x.Id, x));
            _storage = new ConcurrentDictionary<int, TEntity>(keyValues);
        }

        /// <summary>
        /// Добавление записи в промежуточное хранилище
        /// </summary>
        /// <param name="entity">Запись, которую нужно добавить в промежуточное хранилище</param>
        public void Add(TEntity entity)
        {
            _storage[entity.Id] = entity;
        }

        /// <summary>
        /// Удаление записи из промежуточного хранилища
        /// </summary>
        /// <param name="id">Идентификатор записи, которую нужно удалить</param>
        public void Remove(int id)
        {
            if (!_storage.TryRemove(id, out _))
                throw new ArgumentException($"{typeof(TEntity).Name} not found by Id={id}");
        }

        /// <summary>
        /// Замена записи из промежуточного хранилища
        /// </summary>
        /// <param name="entity">Запись, которой нужно заменить существующую в промежуточном хранилище запись с тем же Id</param>
        public void Replace(TEntity entity)
        {
            if (!_storage.TryRemove(entity.Id, out _))
                throw new ArgumentException($"{typeof(TEntity).Name} not found by Id={entity.Id}");

            _storage[entity.Id] = entity;
        }

        /// <summary>
        /// Определяет, есть ли в промежуточном хранилище какие-либо записи
        /// </summary>
        /// <returns>True, если в промежуточном хранилище имеются какие-либо записи. False, если нет</returns>
        public bool Any() => _storage.Any();
    }
}