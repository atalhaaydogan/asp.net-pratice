using Microsoft.AspNetCore.Mvc;

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
            return View("Movies");
        }

        // localhost:26075/movies/details
        public string Details()
        {
            return "Film Detayı";
        }
    }
}
