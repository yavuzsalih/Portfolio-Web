using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Dashboard
{
	public class VisitorMap : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
