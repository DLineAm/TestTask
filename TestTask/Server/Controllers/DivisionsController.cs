using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;

using TestTask.Server.Services;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionsController : Controller
    {
        private readonly ILogger<DivisionsController> _logger;
        private readonly DivisionService _divisionService;

        public DivisionsController(ILogger<DivisionsController> logger, DivisionService divisionService)
        {
            _logger = logger;
            _divisionService = divisionService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Get)}");
            return Ok(_divisionService.GetDivisions());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Division division)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Post)}");

            if (division is null)
                return BadRequest("Division cannot be null");

            try
            {
                _divisionService.AddDivisionToDatabase(division);
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

            if (!_divisionService.TryGetDivision(id, out var division))
                return NotFound();

            try
            {
                _divisionService.DeleteDivision(division);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(DivisionsController)}.{nameof(Delete)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Division division)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Put)}");

            if (!_divisionService.TryGetDivision(division.Id, out var dbDivision))
                return NotFound();

            try
            {
                _divisionService.ChangeDivision(division, dbDivision);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(DivisionsController)}.{nameof(Put)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        
    }
}
