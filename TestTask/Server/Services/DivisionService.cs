using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.Extensions.Logging;
using TestTask.Server.DAL;
using TestTask.Server.Utils;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<DivisionService> _logger;
        private readonly AppData _appData;

        public DivisionService(UnitOfWork unitOfWork ,IHttpContextAccessor accessor, ILogger<DivisionService> logger)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
            _unitOfWork = unitOfWork;
            _logger = logger;
            _appData = new AppData(accessor, unitOfWork);
        }

        /// <summary>
        /// Получение списка подразделений по идентификатору
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Division> Get()
        {
            return _appData.GetDivisions();
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
        public void Add(Division division)
        {
            division.Id = 0;
            var subDivisions = division.SubDivisions.ToList();
            division.SubDivisions = null;
            var entity = _unitOfWork.DivisionRepository
                .Add(division).Entity;

            _unitOfWork.Save();

            foreach (var subDivision in subDivisions)
            {
                var dbDivision = _unitOfWork.DivisionRepository
                    .Get(subDivision.Id);
                if (dbDivision is null)
                {
                    _logger.LogWarning("One of subdivisions is null");
                    continue;
                }

                dbDivision.DivisionId = entity.Id;
            }

            SaveAndUpdateDivisions();
        }

        /// <summary>
        /// Удаление подразделения из бд
        /// </summary>
        /// <param name="division"></param>
        public void Delete(int Id)
        {
            var division = _unitOfWork.DivisionRepository.Get(Id);
            if (division == null)
                throw new SqlNullValueException();

            var subDivisions = _unitOfWork.DivisionRepository.Get(filter: d => d.DivisionId == Id);

            if (subDivisions != null)
            {
                foreach (var subDivision in division.SubDivisions)
                {
                    subDivision.DivisionId = null;
                    subDivision.ParentDivision = null;
                }
            }

            _unitOfWork.Save();

            division.DivisionId = null;
            var employees = _unitOfWork.EmployeeRepository.Get()
                .Select(e => new KeyValuePair<int?,Employee>(e.DivisionId, e));
            var newEmployees = new Dictionary<int?, Employee>();
            foreach (var (id, employee) in employees)
            {
                employee.DivisionId = null;
                newEmployees[id ?? 0] = employee;
            }
            _unitOfWork.Save();

            _unitOfWork.DivisionRepository.Delete(division);
            foreach (var (id, employee) in newEmployees)
            {
                var dbEmployee = _unitOfWork.EmployeeRepository.Get(employee.Id);
                dbEmployee.DivisionId = id == 0 ? null : id;
            }

            SaveAndUpdateDivisions();
        }

        /// <summary>
        /// Изменение подразделения divisionToChange
        /// </summary>
        /// <param name="division"></param>
        public void Change(Division division)
        {
            _unitOfWork.DivisionRepository.Update(division);

            SaveAndUpdateDivisions();
        }

        private void SaveAndUpdateDivisions()
        {
            _unitOfWork.Save();

            _appData.UpdateDivisions();
        }
    }
}