using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public IEnumerable<Employee> GetByDivisionId(int divisionId)
        {
            return _unitOfWork.EmployeeRepository
                    .GetWithChildren(e => e.DivisionId == divisionId);
        }

        /// <summary>
        /// Изменение сотрудника divisionToChange
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="divisionToChange">Сотрудник из бд, которого нужно изменить</param>
        public void Edit(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            //var employeeToChange = _unitOfWork.EmployeeRepository.Get(employee.id);
            //if (employeeToChange == null)
            //    throw new SqlNullValueException();

            //employeeToChange.FirstName = employee.FirstName;
            //employeeToChange.LastName = employee.LastName;
            //employeeToChange.MiddleName = employee.MiddleName;
            //employeeToChange.Gender = employee.Gender;
            //employeeToChange.DateOfBirth = employee.DateOfBirth;
            //employeeToChange.HasDriverLicense = employee.HasDriverLicense;
            //employeeToChange.DivisionId = employee.DivisionId;

            _unitOfWork.Save();
        }

        /// <summary>
        /// Удаление сотрудника из бд
        /// </summary>
        /// <param name="employee"></param>
        public void Delete(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.Get(id);
            if (employee == null)
                throw new SqlNullValueException();

            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Добавление сотрудника в бд
        /// </summary>
        /// <param name="employee"></param>
        public int Add(Employee employee)
        {
            var entry = _unitOfWork.EmployeeRepository.Add(employee).Entity;
            _unitOfWork.Save();
            return entry.Id;
        }
    }
}