using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace İlkProjem.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
            var rules = serviceManager.GetList();
            return View(rules);
        }
    }
}
