using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistik Sayfası";
            return View();
        }
    }
}
