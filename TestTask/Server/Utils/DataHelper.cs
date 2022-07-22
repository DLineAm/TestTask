using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

using System.Collections.Generic;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Utils
{
    public class DataHelper
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly UnitOfWork _unitOfWork;

        public DataHelper(IHttpContextAccessor accessor, UnitOfWork unitOfWork)
        {
            _accessor = accessor;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Division> GetDivisions()
        {
            var divisionFromSession = _accessor.HttpContext?.Session?.GetString("divisions");
            if (divisionFromSession != null)
                return JsonConvert.DeserializeObject<IEnumerable<Division>>(divisionFromSession);

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren();
            _accessor.HttpContext?.Session?.SetString("divisions", JsonConvert.SerializeObject(divisions));
            return divisions;
        }

        public void UpdateDivisions()
        {
            var divisions = _unitOfWork.DivisionRepository.GetWithChildren();
            _accessor.HttpContext?.Session?.SetString("divisions", JsonConvert.SerializeObject(divisions));
        }
    }
}