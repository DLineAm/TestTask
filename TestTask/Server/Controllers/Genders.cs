using Microsoft.AspNetCore.Mvc;
using TestTask.Server.DAL;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Genders : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public Genders(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.GenderRepository.Get());
        }
    }
}