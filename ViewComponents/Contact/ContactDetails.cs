using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ContactManager contactManager = new ContactManager(new EfContactDal());
            var result = contactManager.GetList();
            return View(result);
        }
    }
}
