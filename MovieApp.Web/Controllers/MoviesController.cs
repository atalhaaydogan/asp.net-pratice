using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

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

        // localhost:26075/movies/list/
        // localhost:26075/movies/list/1
        public IActionResult List(int? id, string q)
        {
            //{controller}/{action}/{id?}
            //movies/list/2
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var genreId = RouteData.Values["id"];
            //var kelime = HttpContext.Request.Query["Q"].ToString();

            var movies = MovieRepository.Movies;



            if (id != null) 
            {
                movies = movies.Where(m=>m.GenreId == id).ToList();
            }
            if(!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i=>
                i.Title.ToLower().Contains(q.ToLower()) || 
                i.Description.ToLower().Contains(q.ToLower())).ToList();
            }
            var model = new MoviesViewModel()
            {
                Movies =movies

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
