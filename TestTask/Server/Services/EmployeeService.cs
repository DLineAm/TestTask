using System.Collections.Generic;
using System.Data.SqlTypes;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис сотрудников
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Конструктор сервиса сотрудников
        /// </summary>
        /// <param name="unitOfWork">Класс, хранящий все репозитории с целью гарантии использования одного контекста</param>
        public EmployeeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Получение списка сотрудников по идентификатору
        /// </summary>
        /// <param name="divisionId">Идентификатор подразделения, по которому нужно получить сотрудников</param>
        public IEnumerable<Employee> GetByDivisionId(int divisionId)
        {
            return _unitOfWork.EmployeeRepository
                    .GetWithChildren(e => e.DivisionId == divisionId);
        }

        /// <summary>
        /// Изменение сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно изменить</param>
        public void Edit(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);

            _unitOfWork.Save();
        }

        /// <summary>
        /// Удаление сотрудника из бд
        /// </summary>
        /// <param name="id">Идентификатор, по которому нужно удалить сотрудника</param>
        public void Delete(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.Get(id);

            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Добавление сотрудника в бд
        /// </summary>
        /// <param name="employee">Сотрудник, которого нужно добавить</param>
        public int Add(Employee employee)
        {
            var entry = _unitOfWork.EmployeeRepository.Add(employee).Entity;
            _unitOfWork.Save();
            return entry.Id;
        }
    }
}