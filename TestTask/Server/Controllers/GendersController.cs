using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Server.DAL;
using TestTask.Server.Services;

namespace TestTask.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GendersController : Controller
    {
        private readonly ILogger<GendersController> _logger;
        private readonly GenderService _genderService;


        public GendersController(ILogger<GendersController> logger, GenderService genderService)
        {
            _logger = logger;
            _genderService = genderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Processing request in method {nameof(GendersController)}.{nameof(Get)}");
            return Ok(_genderService.GetGenders());
        }
    }
}