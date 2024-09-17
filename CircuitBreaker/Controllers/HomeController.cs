using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CircuitBreaker.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var client = httpClientFactory.CreateClient("valueAPI");
            var response = await client.GetAsync("api/Home");
            return JsonConvert.DeserializeObject<string[]>(await response.Content.ReadAsStringAsync());
        }

    }
}
    