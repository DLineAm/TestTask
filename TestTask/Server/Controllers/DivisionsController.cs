using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public DivisionsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.DivisionRepository.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Division division)
        {
            if (division == null)
            {
                return BadRequest("Подразделение не может быть равно null");
            }
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
                    if (dbDivision == null)
                    {
                        continue;
                    }

                    dbDivision.DivisionId = entity.Id;
                }

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
            var division = _unitOfWork.DivisionRepository
                .Get(includeProperties: $"{nameof(Division.SubDivisions)}")
                .FirstOrDefault(d => d.Id == id);

            if (division == null)
            {
                return NotFound();
            }

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
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Division division)
        {
            var dbDivision = _unitOfWork.DivisionRepository
                .Get(includeProperties: $"{nameof(Division.SubDivisions)}," +
                                        $"{nameof(Division.Employees)}")
                .FirstOrDefault(d => d.Id == division.Id);

            if (dbDivision == null)
            {
                return NotFound();
            }

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
                    var dbSubDivision = _unitOfWork.DivisionRepository
                        .GetById(subDivision.Id);

                    if (dbSubDivision == null)
                    {
                        continue;
                    }

                    dbDivision.SubDivisions.Add(dbSubDivision);
                }

                _unitOfWork.DivisionRepository.Update(dbDivision);

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
