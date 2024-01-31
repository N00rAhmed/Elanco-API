using Elanco_API.Models;
using Microsoft.AspNetCore.Mvc;
using Elanco_API.Services;

namespace Elanco_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IService bookService;

        public WeatherForecastController(IService bookService)
        {
            this.bookService = bookService;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult<List<WeatherForecast>> Get()
        {
            return bookService.Get();
        }

    }
}