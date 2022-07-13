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

        public DivisionService(UnitOfWork unitOfWork)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Получение списка подразделений по идентификатору
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Division> Get()
        {
            var divisionFromSession = Cache.Session.GetString("divisions");
            if (divisionFromSession != null)
                return JsonConvert.DeserializeObject<IEnumerable<Division>>(divisionFromSession);

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren();
            Cache.Session.SetString("divisions", JsonConvert.SerializeObject(divisions));
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
        }

        /// <summary>
        /// Удаление подразделения из бд
        /// </summary>
        /// <param name="division"></param>
        public void Delete(Division division)
        {
            foreach (var subDivision in division.SubDivisions)
            {
                subDivision.DivisionId = null;
            }

            _unitOfWork.DivisionRepository.Delete(division);
            _unitOfWork.Save();
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
        }
    }
}