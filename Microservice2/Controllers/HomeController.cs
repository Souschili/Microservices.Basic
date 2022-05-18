using Microsoft.AspNetCore.Mvc;

namespace Microservice2.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public string Index()
        {
            return "String from service 2";
        }
    }
}
