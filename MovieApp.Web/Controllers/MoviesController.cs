using Microsoft.AspNetCore.Mvc;
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
            var filmListesi = new List<Movie>()
            {
                new Movie { Title="film 1", 
                    Description="açıklama 1", 
                    Director="yönetmen 1", 
                    Players=new string[] { "oyuncu 1", "oyuncu 2"} },
                new Movie { Title="film 2",
                    Description="açıklama 1", 
                    Director="yönetmen 1", 
                    Players=new string[] { "oyuncu 2", "oyuncu 2"} },
                new Movie { Title="film 1", 
                    Description="açıklama 1", 
                    Director="yönetmen 1", 
                    Players=new string[] { "oyuncu 1", "oyuncu 2"} }
            };
            return View("Movies", filmListesi);
        }

        // localhost:26075/movies/details
        public string Details()
        {
            return "Film Detayı";
        }
    }
}
