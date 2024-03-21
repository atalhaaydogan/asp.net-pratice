using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopulerMovies = MovieRepository.Movies
            };

            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
