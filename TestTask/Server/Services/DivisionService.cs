using System;
using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<DivisionService> _logger;

        public DivisionService(UnitOfWork unitOfWork, IHttpContextAccessor accessor, ILogger<DivisionService> logger)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Получение списка подразделений по идентификатору
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Division> Get()
        {
            return _unitOfWork.DivisionRepository.GetWithChildren();
        }

        /// <summary>
        /// Попытка получить подразделение из бд по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <param name="division"></param>
        /// <returns></returns>
        public bool TryGet(int id, out Division division)
        {
            division = _unitOfWork.DivisionRepository.Get(id);
            return division != null;
        }

        /// <summary>
        /// Добавление подразделения в бд
        /// </summary>
        /// <param name="division"></param>
        public int Add(Division division)
        {
            division.Id = 0;
            var subDivisions = division.SubDivisions.ToList();
            division.SubDivisions = new List<Division>();
            var entity = _unitOfWork.DivisionRepository
                .Add(division).Entity;

            _unitOfWork.Save();

            foreach (var subDivision in subDivisions)
            {
                var dbDivision = _unitOfWork.DivisionRepository.Get(subDivision.Id);
                if (dbDivision is null)
                {
                    _logger.LogWarning("One of subdivisions is null");
                    continue;
                }

                dbDivision.DivisionId = entity.Id;
            }

            _unitOfWork.Save();
            return division.Id;
        }

        /// <summary>
        /// Удаление подразделения из бд
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var division = _unitOfWork.DivisionRepository.Get(id);
            if (division is null)
                throw new ArgumentException($"Division not found by Id={id}");

            var subDivisions = _unitOfWork.DivisionRepository.Get(filter: d => d.DivisionId == id);
            if (subDivisions != null)
            {
                foreach (var subDivision in subDivisions)
                {
                    subDivision.DivisionId = null;
                    subDivision.ParentDivision = null;
                }
            }

            var employeesForDelete = _unitOfWork.EmployeeRepository.Get(x => x.DivisionId == id);
            if (employeesForDelete.Any())
                _unitOfWork.EmployeeRepository.DeleteBulk(employeesForDelete);

            division.DivisionId = null;

            _unitOfWork.DivisionRepository.Delete(division);

            _unitOfWork.Save();
        }

        /// <summary>
        /// Изменение подразделения
        /// </summary>
        /// <param name="division">Модель подразделения</param>
        public void Edit(Division division)
        {
            var subDivisionIds = division.SubDivisions.Select(d => d.Id).ToList();

            division.SubDivisions = new List<Division>();

            _unitOfWork.DivisionRepository.Update(division);

            foreach (var subDivisionId in subDivisionIds)
            {
                var subDivision = _unitOfWork.DivisionRepository.Get(subDivisionId);
                if (subDivision is null)
                {
                    _logger.LogWarning($"One of subdivisions is null by Id={subDivisionId}");
                    continue;
                }

                subDivision.DivisionId = null;
                subDivision.ParentDivision = null;
                _unitOfWork.Save();
                subDivision.DivisionId = division.Id;
            }

            var subDivisionsFromDb = _unitOfWork.DivisionRepository.Get(d => d.DivisionId == division.Id);
            foreach (var subDivisionFromDb in subDivisionsFromDb)
            {
                if (subDivisionIds.All(id => id != subDivisionFromDb.Id))
                {
                    subDivisionFromDb.DivisionId = null;
                }
            }

            _unitOfWork.Save();
        }
    }
}