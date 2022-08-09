using System.Collections.Generic;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Storage
{
    /// <summary>
    /// Сервис по работе с хранилищем сотрудников
    /// </summary>
    public class EmployeeStorageService : StorageService<Employee>, IEmployeeStorageService
    {
        /// <summary>
        /// Конструктор сервиса по работе с хранилищем сотрудников
        /// </summary>
        public EmployeeStorageService(Repository<Employee> repository, IStorage<Employee> storage, UnitOfWork unitOfWork) : base(repository, storage, unitOfWork) { }

        /// <summary>
        /// Получение списка сотрудников по идентификатору подразделения
        /// </summary>
        /// <param name="divisionId">Идентификатор подразделения</param>
        public IEnumerable<Employee> GetByDivisionId(int divisionId)
        {
            return GetAll(employee => employee.DivisionId == divisionId);
        }
    }
}