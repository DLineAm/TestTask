using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;

using TestTask.Server.Services;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    /// <summary>
    /// Контроллер для работы с подразделениями
    /// </summary>
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

        /// <summary>
        /// Получение всех подразделений
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Division>> Get()
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Get)}");

            try
            {
                return Ok(_divisionService.Get());
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(DivisionsController)}.{nameof(Get)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Добавление подразделения в бд
        /// </summary>
        /// <param name="division">Модель подразделения</param>
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

        /// <summary>
        /// Удаление подразделения из бд
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Delete)}");

            try
            {
                _divisionService.Delete(id);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception in {nameof(DivisionsController)}.{nameof(Delete)} was thrown: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Изменение подразделения
        /// </summary>
        /// <param name="division">Измененная модель подразделения</param>
        [HttpPut]
        public IActionResult Put([FromBody] Division division)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Put)}");

            try
            {
                _divisionService.Edit(division);
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
