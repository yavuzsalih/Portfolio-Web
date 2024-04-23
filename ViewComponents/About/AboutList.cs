using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.About
{
	public class AboutList:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			AboutManager aboutManager = new AboutManager(new EfAboutDal());
			var rules = aboutManager.GetList();
			return View(rules);
		}
	}
}
