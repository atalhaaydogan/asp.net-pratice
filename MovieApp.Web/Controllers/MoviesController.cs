using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{   
    // controller
    public class MoviesController : Controller
    {
        // action
        // localhost:26075/movies/list

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {

            var model = new MoviesViewModel()
            {
                Movies = MovieRepository.Movies

            };
            return View("Movies", model);
        }

        // localhost:26075/movies/details/1
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GeyById(id));
        }
    }
}
