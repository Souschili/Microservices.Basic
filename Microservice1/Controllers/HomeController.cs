using Microsoft.AspNetCore.Mvc;

namespace Microservice1.Controllers
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]")]
        public string Index()
        {
            return "Responce from service 1";
        }
    }
}
