using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис подразделений
    /// </summary>
    public interface IDivisionService
    {
        /// <summary>
        /// Получает список подразделений
        /// </summary>
        IEnumerable<Division> Get();

        /// <summary>
        /// Попытка получить подразделение по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        /// <param name="division">Найденное подразделение</param>
        /// <returns>True, если запись подразделение найдено. False, если нет</returns>
        bool TryGet(int id, out Division division);

        /// <summary>
        /// Добавление подразделения
        /// </summary>
        /// <param name="division">Подразделение, которое нужно добавить</param>
        int Add(Division division);

        /// <summary>
        /// Изменение подразделения
        /// </summary>
        /// <param name="division">Подразделение, которое нужно изменить</param>
        void Edit(Division division);

        /// <summary>
        /// Удаление подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения, которое нужно удалить</param>
        void Delete(int id);
    }
}