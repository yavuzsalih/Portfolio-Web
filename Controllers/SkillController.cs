using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using İlkProjem.ViewComponents.Skill;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {

			ViewBag.v1 = "Yetenek Listesi";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Listesi";
			var values = skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenek Ekleme";
            ViewBag.v2 = "Yetenek";
            ViewBag.v3 = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill) 
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");  
        }

        public IActionResult DeleteSkill(int id) 
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id) 
        {
            ViewBag.v1 = "Düzenle";
            ViewBag.v3 = "Yetenekler";
            ViewBag.v2 = "Yetenek Güncelleme";
            var values = skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
