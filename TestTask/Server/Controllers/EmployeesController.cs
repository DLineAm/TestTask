using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public ActionResult<IEnumerable<Employee>> Get(int divisionId)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Get)}");
            //
            if (!_divisionService.TryGet(divisionId, out _))
                return NotFound();
            //
            var employees = _employeeService.GetByDivisionId(divisionId);

            return Ok(employees);
        }

        [HttpPut("change")]
        public IActionResult Put([FromBody] Employee employee)
        {
            _logger.LogInformation($"Processing request in method {nameof(EmployeesController)}.{nameof(Put)}");

            try
            {
                _employeeService.Change(employee);
                return Ok();
            }
            catch (SqlNullValueException)
            {
                return NotFound();
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

            try
            {
                _employeeService.Delete(id);
                return Ok();
            }
            catch (SqlNullValueException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(EmployeesController)}.{nameof(Delete)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<int> Post([FromBody] Employee employee)
        {
            if (employee is null)
                return BadRequest("Employee cannot be null");

            try
            {
                var id = _employeeService.Add(employee);
                return Ok(id);
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(EmployeesController)}.{nameof(Post)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}