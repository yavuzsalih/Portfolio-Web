﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace İlkProjem.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v3 = "Öne Çıkanlar";
            ViewBag.v2 = "Öne Çıkanlar Sayfası";
            var values = featureManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}