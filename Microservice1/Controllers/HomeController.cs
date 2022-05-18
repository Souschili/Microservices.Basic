using Microsoft.AspNetCore.Mvc;

namespace Microservice1.Controllers
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("index")]
        public string Index()
        {
            return "String from service 1";
        }
    }
}
