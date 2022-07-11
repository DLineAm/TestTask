using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Server.DAL;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GendersController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<GendersController> _logger;

        public GendersController(UnitOfWork unitOfWork, ILogger<GendersController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Processing request in method {nameof(GendersController)}.{nameof(Get)}");
            return Ok(_unitOfWork.GenderRepository.Get());
        }
    }
}