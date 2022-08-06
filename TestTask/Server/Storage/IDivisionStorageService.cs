using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TestTask.Shared;

namespace TestTask.Server.Storage
{
    /// <summary>
    /// Интерфейс, представляющий сервис по работе с данными
    /// </summary>
    public interface IDivisionStorageService
    {
        /// <summary>
        /// Получение списка подразделений
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        IEnumerable<Division> GetAll(Expression<Func<Division, bool>> filter = null);

        /// <summary>
        /// Получение подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        Division Get(int id);

        /// <summary>
        /// Добавление подразделения в хранилище
        /// </summary>
        /// <param name="division">Подразделение, которую нужно добавить в хранилище</param>
        /// <returns>Идентификатор добавленного подразделения</returns>
        int Add(Division division);

        /// <summary>
        /// Сохранение и обновление подразделения из хранилища записью entity
        /// </summary>
        /// <param name="division">Подразделение, которое нужно сохранить и заменить в хранилище</param>
        void SaveAndUpdate(Division division);

        /// <summary>
        /// Удаление подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения, которое нужно удалить</param>
        void Delete(int id);

        /// <summary>
        /// Заполнение кэша списком подразделений
        /// </summary>
        void FillCache();
    }
}