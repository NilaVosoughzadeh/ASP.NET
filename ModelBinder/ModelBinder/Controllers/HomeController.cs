using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string name , string family , int? age)
        {
            if (age != null & age < 18)
            {
                ViewBag.Message = "سن شما قانونی نیست بچه جون";
                return View("_Message");
            }
            ViewBag.name = name;
            ViewBag.family = family;
            ViewBag.age = age;
            return View();
        }
    }
}