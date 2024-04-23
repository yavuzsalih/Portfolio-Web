using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values =_portfolioManager.GetList();
            return View(values);
        }
    }
}
