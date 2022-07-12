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

        public IEnumerable<Employee> GetWithParameter(object param)
        {
            if (param is int divisionId)
            {
                return _unitOfWork.EmployeeRepository
                    .GetWithChildren(e => e.DivisionId == divisionId);
            }

            throw new InvalidOperationException("param must be int");
        }

        public bool TryGet(int id, out Employee employee)
        {
            employee = _unitOfWork.EmployeeRepository.GetById(id);
            return employee != null;
        }

        public void Change(Employee employee, Employee employeeToChange)
        {
            employeeToChange.FirstName = employee.FirstName;
            employeeToChange.LastName = employee.LastName;
            employeeToChange.MiddleName = employee.MiddleName;
            employeeToChange.GenderId = employee.GenderId;
            employeeToChange.DateOfBirth = employee.DateOfBirth;
            employeeToChange.HasDriverLicense = employee.HasDriverLicense;
            employeeToChange.DivisionId = employee.DivisionId;

            _unitOfWork.Save();
        }

        public void Delete(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Save();
        }

        public void Add(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Insert(employee);
            _unitOfWork.Save();
        }
    }
}