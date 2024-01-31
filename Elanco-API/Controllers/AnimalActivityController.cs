using Elanco_API.Models;
using Microsoft.AspNetCore.Mvc;
using Elanco_API.Services;

namespace Elanco_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalActivityController : ControllerBase
    {
        private readonly Http_Requests functionality;

        public AnimalActivityController(Http_Requests bookService)
        {
            this.functionality = bookService;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult<List<AnimalActivity>> Get()
        {
            return functionality.Get();
        }

    }
}