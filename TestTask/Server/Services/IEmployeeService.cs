using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис сотрудников
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Получение списка сотрудников по идентификатору
        /// </summary>
        /// <param name="divisionId">Идентификатор подразделения, по которому нужно получить сотрудников</param>
        IEnumerable<Employee> GetByDivisionId(int divisionId);

        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно добавить</param>
        int Add(Employee employee);

        /// <summary>
        /// Изменение сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно изменить</param>
        void Edit(Employee employee);

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="id">Идентификатор, по которому нужно удалить сотрудника</param>
        void Delete(int id);
    }
}