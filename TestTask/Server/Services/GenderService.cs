using System.Collections.Generic;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class GenderService
    {
        private UnitOfWork _unitOfWork;

        public GenderService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Gender> GetGenders()
        {
            return _unitOfWork.GenderRepository.Get();
        }
    }
}