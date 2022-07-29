using System.Collections.Generic;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Сервис по работе с хранилищем сотрудников
    /// </summary>
    public class EmployeeStorageService : IEmployeeStorageService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Cache _cache;

        /// <summary>
        /// Конструктор сервиса по работе с хранилищем сотрудников
        /// </summary>
        /// <param name="unitOfWork">Класс, хранящий все репозитории с целью гарантии использования одного контекста</param>
        /// <param name="cache">Класс, имеющий хранилища списков сотрудников</param>
        public EmployeeStorageService(UnitOfWork unitOfWork, Cache cache)
        {
            _unitOfWork = unitOfWork;
            _cache = cache;
        }

        /// <summary>
        /// Получение списка сотрудников по идентификатору подразделения
        /// </summary>
        /// <param name="divisionId">Идентификатор подразделения</param>
        /// <param name="forceFromDb">Получить список сотрудников принудительно из бд</param>
        public IEnumerable<Employee> GetByDivisionId(int divisionId, bool forceFromDb = false)
        {
            if (_cache.EmployeeStorage.Any() && !forceFromDb)
                return _cache.EmployeeStorage.GetAll();

            var employees = _unitOfWork.EmployeeRepository.GetWithChildren(e => e.DivisionId == divisionId);

            _cache.EmployeeStorage.Fill(employees);

            return employees;
        }

        /// <summary>
        /// Добавление сотрудника в хранилище
        /// </summary>
        /// <param name="employee">Сотрудник, которого нкжно добавить в хранилище</param>
        /// <returns>Идентификатор добавленного сотрудника</returns>
        public int Add(Employee employee)
        {
            var entry = _unitOfWork.EmployeeRepository.Add(employee).Entity;
            _unitOfWork.Save();

            _cache.EmployeeStorage.Add(entry);

            return entry.Id;
        }

        /// <summary>
        /// Сохранение и обновление сотрудника в хранилище
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно сохранить и обновить в хранилище</param>
        public void SaveAndUpdate(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);

            _unitOfWork.Save();

            _cache.EmployeeStorage.Replace(employee);
        }

        /// <summary>
        /// Удаление сотрудника из хранилища по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор сотрудника, которого нужно удалить из бд</param>
        public void Delete(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.Get(id);

            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Save();

            _cache.EmployeeStorage.Remove(id);
        }
    }
}