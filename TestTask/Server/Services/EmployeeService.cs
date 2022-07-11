using System.Collections.Generic;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class EmployeeService
    {
        private readonly UnitOfWork _unitOfWork;

        public EmployeeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Employee> GetEmployeesFromDivision(int divisionId)
        {
            return _unitOfWork.EmployeeRepository
                .GetWithChildren(e => e.DivisionId == divisionId);
        }

        public bool TryGetEmployee(int id, out Employee employee)
        {
            employee = _unitOfWork.EmployeeRepository.GetById(id);
            return employee != null;
        }

        public void ChangeEmployee(Employee employee, Employee employeeToChange)
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

        public void DeleteEmployeeFromDatabase(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Save();
        }

        public void AddEmployeeToDatabase(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Insert(employee);
            _unitOfWork.Save();
        }
    }
}