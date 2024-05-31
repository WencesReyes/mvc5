using mvc_project.Models.Movie;
using mvc_project.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace mvc_project.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<ActionResult> Index()
        {
            var movies = await _movieService.GetAllAsync();

            return View(movies);
        }

        public async Task<ActionResult> Details(int id, int? age)
        {
            var movie = await _movieService.GetByIdAsync(id);

            ViewBag.Movie = movie;

            return View(movie);
        }

        [HttpGet]
        public async Task<ActionResult> Create(int? id)
        {
            if (id is null)
            {
                return View();
            }

            var movie = await _movieService.GetByIdAsync(id.Value);

            return View((CreateUpdateMovie)movie);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Create(CreateUpdateMovie movie)
        {
            if (ModelState.IsValid) 
            {
                if (movie.Id is null) 
                {
                    await _movieService.AddAsync(movie);
                }
                else
                {
                    await _movieService.UpdateAsync(movie);
                }

                return RedirectToAction("Index");
            }

            return View(movie);
        }
    }
}