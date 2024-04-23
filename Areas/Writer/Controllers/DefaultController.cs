using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
	{
        AnnouncemenManager announcemenManager = new AnnouncemenManager(new EfAnnouncementDal());
        public IActionResult Index()
		{
            var item= announcemenManager.GetList();
			return View(item);
		}

        public IActionResult AnnouncemenManagerDetails(int id)
        {
            Announcement announcement = announcemenManager.TGetByID(id);
            return View(announcement);
        }

    }
}
