using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис сотрудников
    /// </summary>
    public interface IEmployeeService : IMaybeGettable<Employee>, IWritable<Employee>
    {
        IEnumerable<Employee> GetByDivisionId(int divisionId);
    }
}