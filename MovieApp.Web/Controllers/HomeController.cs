using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "film başlığı";
            string filmAcıklama = "film açıklaması";
            string filmYonetmen = "film yönetmen adı";
            string[] oyuncular = {"oyuncu 1", "oyuncu 2", "oyuncu 3", "oyuncu 4" };

            var m = new Movie();

            m.Title = filmBasligi;
            m.Description = filmAcıklama;
            m.Director = filmYonetmen;
            m.Players = oyuncular;
            m.ImageUrl = "1.jpg";

            return View(m);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
