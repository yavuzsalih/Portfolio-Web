using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
            var result = testimonialManager.GetList();
            return View(result);
        }
    }
}
