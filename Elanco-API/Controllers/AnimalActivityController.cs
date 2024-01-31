using Elanco_API.Models;
using Microsoft.AspNetCore.Mvc;
using Elanco_API.Services;

namespace Elanco_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalActivityController : ControllerBase
    {
        private readonly Http_Requests bookService;

        public AnimalActivityController(Http_Requests bookService)
        {
            this.bookService = bookService;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult<List<AnimalActivity>> Get()
        {
            return bookService.Get();
        }

    }
}