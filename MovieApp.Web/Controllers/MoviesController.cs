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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // localhost:26075/movies/list/
        // localhost:26075/movies/list/1
        [HttpGet]
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
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GeyById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            // modelbinding
            //var m = new Movie()
            //{
            //    Title = Title,
            //    Description = Description,
            //    Director = Director,
            //    ImageUrl = ImageUrl,
            //    GenreId = GenreId
            //};
            MovieRepository.Add(m);

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(MovieRepository.GeyById(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            MovieRepository.Edit(m);
            // /movies/details/1
            return RedirectToAction("Details", "Movies", new { @id = m.MovieId});
        }
    }
}
