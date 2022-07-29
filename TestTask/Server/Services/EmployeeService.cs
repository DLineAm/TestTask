using System.Collections.Generic;

using TestTask.Server.DAL;
using TestTask.Server.Utils;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис сотрудников
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly DataServiceCollection _serviceCollection;

        /// <summary>
        /// Конструктор сервиса сотрудников
        /// </summary>
        /// <param name="serviceCollection">Класс, хранящий сервисы по работе с хранилищем</param>
        public EmployeeService(DataServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        /// <summary>
        /// Получение списка сотрудников по идентификатору
        /// </summary>
        /// <param name="divisionId">Идентификатор подразделения, по которому нужно получить сотрудников</param>
        public IEnumerable<Employee> GetByDivisionId(int divisionId)
        {
            return _serviceCollection.Employees.GetByDivisionId(divisionId);
        }

        /// <summary>
        /// Изменение сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно изменить</param>
        public void Edit(Employee employee)
        {
            _serviceCollection.Employees.SaveAndUpdate(employee);
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="id">Идентификатор, по которому нужно удалить сотрудника</param>
        public void Delete(int id)
        {
            _serviceCollection.Employees.Delete(id);
        }

        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно добавить</param>
        public int Add(Employee employee)
        {
            return _serviceCollection.Employees.Add(employee);
        }
    }
}