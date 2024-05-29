﻿using mvc_project.Services;
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
    }
}