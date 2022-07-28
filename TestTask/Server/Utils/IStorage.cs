using System;
using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Интерфейс, представляющий хранилище с возможностью чтения и записи данных
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStorage<T> where T : IIdentity, new()
    {

        /// <summary>
        /// Получение списка записей
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        IEnumerable<T> GetAll(Func<T, bool> filter = null);

        /// <summary>
        /// Получение записи по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор нужной записи</param>
        T Get(int id);

        /// <summary>
        /// Получение первой подходящей записи по выражению
        /// </summary>
        /// <param name="expression">Выражение, с помощью которого нужно найти первую подходящую запись</param>
        T Get(Func<T, bool> expression);

        /// <summary>
        /// Заполнение хранилища с помощью списка записей
        /// </summary>
        /// <param name="entities">Список записей, требуемый для заполнения хранилища</param>
        void Fill(IEnumerable<T> entities);

        /// <summary>
        /// Добавление записи в хранилище
        /// </summary>
        /// <param name="entity">Запись, которую нужно добавить в хранилище</param>
        void Add(T entity);

        /// <summary>
        /// Удаление записи из хранилища
        /// </summary>
        /// <param name="id">Идентификатор записи, которую нужно удалить</param>
        void Remove(int id);

        /// <summary>
        /// Замена записи из хранилища
        /// </summary>
        /// <param name="entity">Запись, которой нужно заменить существующую в хранилище запись с тем же Id</param>
        void Replace(T entity);

        /// <summary>
        /// Определяет, есть ли в хранилище какие-либо записи
        /// </summary>
        /// <returns>True, если в хранилище имеются какие-либо записи. False, если нет</returns>
        bool Any();
    }
}