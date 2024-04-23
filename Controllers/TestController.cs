using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
