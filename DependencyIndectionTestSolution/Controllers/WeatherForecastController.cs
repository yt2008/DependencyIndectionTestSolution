using DependencyIndectionTestSolution.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyIndectionTestSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IService1 _service1;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IService1 service1)
        {
            _logger = logger;
            _service1 = service1;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _service1.GetResult1Async();
        }
    }
}
