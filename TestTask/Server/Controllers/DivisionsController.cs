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
    public class DivisionsController : Controller
    {
        private readonly ILogger<DivisionsController> _logger;
        private readonly IDivisionService _divisionService;

        public DivisionsController(ILogger<DivisionsController> logger, IDivisionService divisionService)
        {
            _logger = logger;
            _divisionService = divisionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Division>> Get()
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Get)}");
            return Ok(_divisionService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Division division)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Post)}");

            if (division is null)
                return BadRequest("Division cannot be null");

            try
            {
                _divisionService.Add(division);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(DivisionsController)}.{nameof(Post)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Delete)}");

            try
            {
                _divisionService.Delete(id);
                return Ok();
            }
            catch (SqlNullValueException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                _logger.LogError(
                    $"Exception in {nameof(DivisionsController)}.{nameof(Delete)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Division division)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Put)}");

            try
            {
                _divisionService.Change(division);
                return Ok();
            }
            catch (SqlNullValueException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(DivisionsController)}.{nameof(Put)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }

        }
    }
}
