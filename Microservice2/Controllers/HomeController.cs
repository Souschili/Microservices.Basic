using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microservice2.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public HomeController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        private IHttpClientFactory _httpClient { get; }

        [HttpGet("[action]")]
        public async Task<IActionResult> Index()
        {

            var client=_httpClient.CreateClient();

           var getResult=await client.GetAsync("https://localhost:5001/home/index");

            var responce=await getResult.Content.ReadAsStringAsync();

            return Ok(responce);
        }
    }
}
