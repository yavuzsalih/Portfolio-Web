using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SkillManager skillManager = new SkillManager(new EfSkillDal());
            var result = skillManager.GetList();
            return View(result);
        }
    }
}
