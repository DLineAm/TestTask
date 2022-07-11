using System.Collections.Generic;
using System.Linq;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class DivisionService
    {
        private UnitOfWork _unitOfWork;

        public DivisionService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Division> GetDivisions()
        {
            return _unitOfWork.DivisionRepository.GetWithChildren();
        }

        public bool TryGetDivision(int id, out Division division)
        {
            division = GetDivisions().FirstOrDefault(d => d.Id == id);
            return division != null;
        }

        public void AddDivisionToDatabase(Division division)
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

        public void DeleteDivision(Division division)
        {
            foreach (var subDivision in division.SubDivisions)
            {
                subDivision.DivisionId = null;
            }

            _unitOfWork.DivisionRepository.Delete(division);
            _unitOfWork.Save();
        }

        public void ChangeDivision(Division division, Division dbDivision)
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
        }
    }
}