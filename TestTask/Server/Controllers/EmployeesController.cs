using Microsoft.AspNetCore.Mvc;

using System;
using Microsoft.Extensions.Logging;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(UnitOfWork unitOfWork, ILogger<EmployeesController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(int divisionId)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Get)}");

            if (_unitOfWork.DivisionRepository.GetById(divisionId) is null)
                return NotFound();

            var employees = _unitOfWork.EmployeeRepository
                .GetWithChildren(e => e.DivisionId == divisionId);

            return Ok(employees);
        }

        [HttpPut("change")]
        public IActionResult Put([FromBody] Employee employee)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Put)}");

            var dbEmployee = _unitOfWork.EmployeeRepository
                .GetById(employee.Id);

            if (dbEmployee is null)
                return NotFound();

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
                _logger.LogError($"Exception in {nameof(EmployeesController)}.{nameof(Put)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Delete)}");

            var employee = _unitOfWork.EmployeeRepository.GetById(id);

            if (employee is null)
                return NotFound();

            try
            {
                _unitOfWork.EmployeeRepository.Delete(employee);
                _unitOfWork.Save();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(EmployeesController)}.{nameof(Delete)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee is null)
                return BadRequest("Employee cannot be null");

            try
            {
                _unitOfWork.EmployeeRepository.Insert(employee);
                _unitOfWork.Save();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(EmployeesController)}.{nameof(Post)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}