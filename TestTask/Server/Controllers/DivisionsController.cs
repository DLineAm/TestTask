using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Server.DAL;
using TestTask.Server.DAL.Context;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<DivisionsController> _logger;

        public DivisionsController(UnitOfWork unitOfWork, ILogger<DivisionsController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Get)}");
            return Ok(_unitOfWork.DivisionRepository.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Division division)
        {
            _logger.LogInformation($"Processing request in method {nameof(DivisionsController)}.{nameof(Post)}");

            if (division is null)
                return BadRequest("Division cannot be null");

            try
            {
                division.Id = 0;
                var subDivisions = division.SubDivisions.ToList();
                division.SubDivisions = null;
                var entity = _unitOfWork.DivisionRepository
                    .Insert(division).Entity;

                _unitOfWork.Save();

                foreach (var subDivision in subDivisions)
                {
                    var dbDivision = _unitOfWork.DivisionRepository
                        .GetById(subDivision.Id);
                    if (dbDivision is null)
                        continue;

                    dbDivision.DivisionId = entity.Id;
                }

                _unitOfWork.Save();
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

            var division = _unitOfWork.DivisionRepository
                .GetWithChildren()
                .FirstOrDefault(d => d.Id == id);

            if (division is null)
                return NotFound();

            try
            {
                foreach (var subDivision in division.SubDivisions)
                {
                    subDivision.DivisionId = null;
                }

                _unitOfWork.DivisionRepository.Delete(division);
                _unitOfWork.Save();
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

            var dbDivision = _unitOfWork.DivisionRepository
                .GetWithChildren()
                .FirstOrDefault(d => d.Id == division.Id);

            if (dbDivision is null)
                return NotFound();

            try
            {
                dbDivision.Title = division.Title;
                dbDivision.Description = division.Description;
                dbDivision.DivisionId = division.DivisionId;
                dbDivision.CreateDate = division.CreateDate;

                var subDivisions = division.SubDivisions;

                dbDivision.SubDivisions = new HashSet<Division>();

                foreach (var subDivision in subDivisions)
                {
                    var dbSubDivision = _unitOfWork.DivisionRepository.GetById(subDivision.Id);

                    if (dbSubDivision is null)
                        continue;

                    dbDivision.SubDivisions.Add(dbSubDivision);
                }

                _unitOfWork.DivisionRepository.Update(dbDivision);
                _unitOfWork.Save();
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
