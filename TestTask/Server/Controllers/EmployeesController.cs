using Microsoft.AspNetCore.Mvc;

using System;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public EmployeesController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get(int divisionId)
        {
            if (_unitOfWork.DivisionRepository.GetById(divisionId) == null)
            {
                return NotFound();
            }

            var employees = _unitOfWork.EmployeeRepository
                .Get(filter: e => e.DivisionId == divisionId,
                    includeProperties: $"{nameof(Employee.Division)}," +
                                       $"{nameof(Employee.Gender)}");

            return Ok(employees);
        }

        [HttpPut("change")]
        public IActionResult Put([FromBody] Employee employee)
        {
            var dbEmployee = _unitOfWork.EmployeeRepository
                .GetById(employee.Id);

            if (dbEmployee == null)
            {
                return NotFound();
            }

            try
            {
                dbEmployee.FirstName = employee.FirstName;
                dbEmployee.LastName = employee.LastName;
                dbEmployee.MiddleName = employee.MiddleName;
                dbEmployee.GenderId = employee.GenderId;
                dbEmployee.DateOfBirth = employee.DateOfBirth;
                dbEmployee.HasDriverLicense = employee.HasDriverLicense;
                dbEmployee.DivisionId = employee.DivisionId;

                _unitOfWork.Save();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            var employee = _unitOfWork.EmployeeRepository
                .GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            try
            {
                _unitOfWork.EmployeeRepository
                    .Delete(employee);
                _unitOfWork.Save();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Сотрудник не должен быть равен null");
            }

            try
            {
                _unitOfWork.EmployeeRepository
                    .Insert(employee);
                _unitOfWork.Save();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}