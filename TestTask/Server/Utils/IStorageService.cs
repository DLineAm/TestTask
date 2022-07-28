using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Интерфейс, представляющий сервис по работе с данными
    /// </summary>
    public interface IStorageService<T>
    {
        /// <summary>
        /// Получение списка данных
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        /// <param name="forceFromDb">Принудительно искать данные в бд</param>
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, bool forceFromDb = false);

        /// <summary>
        /// Получение записи
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        /// <param name="forceFromDb">Принудительно искать запись в бд</param>
        T Get(int id, bool forceFromDb = false);

        /// <summary>
        /// Добавление записи в хранилище
        /// </summary>
        /// <param name="entity">Запись, которую нужно добавить в хранилище</param>
        /// <returns>Идентификатор добавленной записи</returns>
        int Add(T entity);

        /// <summary>
        /// Обновление записи из хранилища записью entity
        /// </summary>
        /// <param name="entity">Обновленная запись, которую нужно заменить в хранилище</param>
        void Update(T entity);

        /// <summary>
        /// Сохранение и обновление записи из хранилища записью entity
        /// </summary>
        /// <param name="entity">Запись, которую нужно сохранить и заменить в хранилище</param>
        void SaveAndUpdate(T entity);

        /// <summary>
        /// Сохранение записи
        /// </summary>
        void Save();

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="id">Идентификатор записи, которую нужно удалить</param>
        void Delete(int id);
    }
}