using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис сотрудников
    /// </summary>
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetByDivisionId(int divisionId);
        int Add(Employee item);
        void Edit(Employee item);
        void Delete(int id);
    }
}