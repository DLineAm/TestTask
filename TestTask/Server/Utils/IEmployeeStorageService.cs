using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Интерфейс, представляющий сервис по работе с данными
    /// </summary>
    public interface IEmployeeStorageService
    {
        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <param name="divisionId">Идентификатор подразделения, по которому нужно найти сотрудников</param>
        /// <param name="forceFromDb">Принудительно искать данные в бд</param>
        IEnumerable<Employee> GetByDivisionId(int divisionId, bool forceFromDb = false);

        /// <summary>
        /// Добавление сотрудника в хранилище
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно добавить в хранилище</param>
        /// <returns>Идентификатор добавленного сотрудника</returns>
        int Add(Employee employee);

        /// <summary>
        /// Сохранение и обновление сотрудника из хранилища записью employee
        /// </summary>
        /// <param name="employee">Запись сотрудника, которую нужно сохранить и заменить в хранилище</param>
        void SaveAndUpdate(Employee employee);

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="id">Идентификатор сотрудника, которого нужно удалить</param>
        void Delete(int id);
    }
}