using System;
using System.Collections.Generic;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly UnitOfWork _unitOfWork;

        public EmployeeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Получение списка сотрудников по идентификатору
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public IEnumerable<Employee> GetWithParameter(object param)
        {
            if (param is int divisionId)
                return _unitOfWork.EmployeeRepository
                    .GetWithChildren(e => e.DivisionId == divisionId);

            throw new InvalidOperationException("param must be int");
        }

        /// <summary>
        /// Попытка получить сотрудника из бд по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool TryGet(int id, out Employee employee)
        {
            employee = _unitOfWork.EmployeeRepository.GetById(id);
            return employee != null;
        }

        /// <summary>
        /// Изменение сотрудника divisionToChange
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="divisionToChange">Сотрудник из бд, которого нужно изменить</param>
        public void Change(Employee employee, Employee divisionToChange)
        {
            divisionToChange.FirstName = employee.FirstName;
            divisionToChange.LastName = employee.LastName;
            divisionToChange.MiddleName = employee.MiddleName;
            divisionToChange.GenderId = employee.GenderId;
            divisionToChange.DateOfBirth = employee.DateOfBirth;
            divisionToChange.HasDriverLicense = employee.HasDriverLicense;
            divisionToChange.DivisionId = employee.DivisionId;

            _unitOfWork.Save();
        }

        /// <summary>
        /// Удаление сотрудника из бд
        /// </summary>
        /// <param name="employee"></param>
        public void Delete(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Добавление сотрудника в бд
        /// </summary>
        /// <param name="employee"></param>
        public void Add(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Insert(employee);
            _unitOfWork.Save();
        }
    }
}