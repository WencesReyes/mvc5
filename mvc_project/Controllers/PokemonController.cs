using mvc_project.Models.Pokemon;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace mvc_project.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PokemonController(
            IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ActionResult> Index()
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/");
         
            var pokemonResponse = JsonConvert.DeserializeObject<PokemonResponse>(await response.Content.ReadAsStringAsync());

            return View(pokemonResponse.Results);
        }
    }
}