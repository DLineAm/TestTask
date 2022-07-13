using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TestTask.Server.DAL;
using TestTask.Server.Utils;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _accessor;

        public DivisionService(UnitOfWork unitOfWork ,IHttpContextAccessor accessor)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
            _unitOfWork = unitOfWork;
            _accessor = accessor;
        }

        /// <summary>
        /// Получение списка подразделений по идентификатору
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Division> Get()
        {
            var divisionFromSession = _accessor.HttpContext?.Session?.GetString("divisions");
            if (divisionFromSession != null)
                return JsonConvert.DeserializeObject<IEnumerable<Division>>(divisionFromSession);

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren();
            _accessor.HttpContext?.Session?.SetString("divisions", JsonConvert.SerializeObject(divisions));
            return divisions;

        }

        /// <summary>
        /// Попытка получить подразделение из бд по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <param name="division"></param>
        /// <returns></returns>
        public bool TryGet(int id, out Division division)
        {
            division = Get().FirstOrDefault(d => d.Id == id);
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

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren();
            _accessor.HttpContext?.Session?.SetString("divisions", JsonConvert.SerializeObject(divisions));
        }

        /// <summary>
        /// Удаление подразделения из бд
        /// </summary>
        /// <param name="division"></param>
        public void Delete(Division division)
        {
            if (division.SubDivisions != null)
            {
                foreach (var subDivision in division.SubDivisions)
                {
                    subDivision.DivisionId = null;
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

            var dbDivision = _unitOfWork.DivisionRepository.GetById(division.Id);

            _unitOfWork.DivisionRepository.Delete(dbDivision);
            foreach (var (id, employee) in newEmployees)
            {
                var dbEmployee = _unitOfWork.EmployeeRepository.GetById(employee.Id);
                dbEmployee.DivisionId = id == 0 ? null : id;
            }
            _unitOfWork.Save();

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren().ToList();
            _accessor.HttpContext?.Session?.SetString("divisions", JsonConvert.SerializeObject(divisions));
        }

        /// <summary>
        /// Изменение подразделения divisionToChange
        /// </summary>
        /// <param name="division"></param>
        /// <param name="divisionToChange"></param>
        public void Change(Division division, Division divisionToChange)
        {
            divisionToChange.Title = division.Title;
            divisionToChange.Description = division.Description;
            divisionToChange.DivisionId = division.DivisionId;
            divisionToChange.CreateDate = division.CreateDate;

            var subDivisions = division.SubDivisions;

            divisionToChange.SubDivisions = new HashSet<Division>();

            foreach (var subDivision in subDivisions)
            {
                var dbSubDivision = _unitOfWork.DivisionRepository.GetById(subDivision.Id);

                if (dbSubDivision is null)
                    continue;

                divisionToChange.SubDivisions.Add(dbSubDivision);
            }

            _unitOfWork.DivisionRepository.Update(divisionToChange);
            _unitOfWork.Save();

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren();
            _accessor.HttpContext?.Session?.SetString("divisions", JsonConvert.SerializeObject(divisions));
        }
    }
}