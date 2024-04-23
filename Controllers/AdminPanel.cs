using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Controllers
{
    public class AdminPanel : Controller
    {
        public PartialViewResult SideNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        } public PartialViewResult PartialHead()
        {
            return PartialView();
        } public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }

        public PartialViewResult NewSideBar()
        {
            return PartialView();
        }
    }
}
