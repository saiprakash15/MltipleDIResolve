using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MltipleDIResolve.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly StreamFactory _streamService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, StreamFactory streamservice)
        {
            _logger = logger;
            _streamService = streamservice;
        }

        [HttpGet("movies/{userSelection}")]
        public string[] GetMovies(string userSelection)
        {
            
            return _streamService.GetStreamingService(userSelection).ShowMovies();
        }
    }
}
