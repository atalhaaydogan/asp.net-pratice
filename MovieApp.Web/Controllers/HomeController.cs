using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "film başlığı";
            string filmAcıklama = "film açıklaması";
            string filmBYonetmen = "film yönetmen adı";
            string[] oyuncular = {"oyuncu 1", "oyuncu 2", "oyuncu 3", "oyuncu 4" };

            ViewBag.FilmBasligi = filmBasligi;
            ViewBag.FilmAcıklamasi = filmAcıklama;
            ViewBag.FilmYonetmeni = filmBYonetmen;
            ViewBag.Oyuncular = oyuncular;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
