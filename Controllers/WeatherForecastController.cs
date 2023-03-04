using Microsoft.AspNetCore.Mvc;

namespace AppSettingsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IAppConfig _appconfig;

        public WeatherForecastController(IAppConfig appconfig)
        {
            _appconfig = appconfig;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var result = _appconfig.GetTestValue();
            return Ok(result);
        }
    }
}