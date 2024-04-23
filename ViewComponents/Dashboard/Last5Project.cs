using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Dashboard
{
    public class Last5Project:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
