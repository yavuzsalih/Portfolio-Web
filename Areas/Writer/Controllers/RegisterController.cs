using EntityLayer.Concrete;
using İlkProjem.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p) // taska dikkat et
        {
            if (ModelState.IsValid)
            {
                if(p.Password==p.ConfirmPassword)
                { 
                }
                WriterUser w = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.SurName,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageUrl = p.ImageUrl
                };

                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(w, p.Password);



                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }
            return View(p);
        }
    }
}
