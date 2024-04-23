using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
            
            var values =featureManager.GetList();
            return View(values);
        }
    }
}
