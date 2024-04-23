using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
            var result = experienceManager.GetList();
            return View(result);
        }
    }
}
