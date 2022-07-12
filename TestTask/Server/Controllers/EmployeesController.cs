using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;

using TestTask.Server.Services;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly IDivisionService _divisionService;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeeService employeeService, IDivisionService divisionService)
        {
            _logger = logger;
            _employeeService = employeeService;
            _divisionService = divisionService;
        }

        [HttpGet]
        public IActionResult Get(int divisionId)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Get)}");

            if (!_divisionService.TryGet(divisionId, out _))
                return NotFound();

            var employees = _employeeService.GetWithParameter(divisionId);

            return Ok(employees);
        }

        [HttpPut("change")]
        public IActionResult Put([FromBody] Employee employee)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Put)}");

            if (!_employeeService.TryGet(employee.Id, out var dbEmployee))
                return NotFound();

            try
            {
                _employeeService.Change(employee, dbEmployee);
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

            if (!_employeeService.TryGet(id, out var employee))
                return NotFound();

            try
            {
                _employeeService.Delete(employee);
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
                _employeeService.Add(employee);
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