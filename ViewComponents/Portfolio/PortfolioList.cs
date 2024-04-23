using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Portfolio
{
	public class PortfolioList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
			var result = portfolioManager.GetList();
			return View(result);
		}
	}
}
