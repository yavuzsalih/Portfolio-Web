using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());

        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMesssagesWithUserService();
            return View(values);
        }
    }
}
