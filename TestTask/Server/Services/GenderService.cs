using System.Collections.Generic;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public class GenderService : IGenderService
    {
        private readonly UnitOfWork _unitOfWork;

        public GenderService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Получение списка гендеров
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Gender> Get()
        {
            return _unitOfWork.GenderRepository.Get();
        }
    }
}