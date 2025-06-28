using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View("ContactUs");
        }

        public ActionResult AboutUs()
        {
            return View("About");
        }
    }
}