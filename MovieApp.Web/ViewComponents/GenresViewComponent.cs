using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var turListesi = new List<Genre>() {
                new Genre {Name = "Mecara"},
                new Genre {Name = "Komedi"},
                new Genre {Name = "Romantik"},
                new Genre {Name = "Savaş"}
            };

            return View(turListesi);

        }
    }
}
