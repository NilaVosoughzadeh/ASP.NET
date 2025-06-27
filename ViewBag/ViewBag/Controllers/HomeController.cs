using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            dynamic data = "Boy";

            ViewBag.data = "Arash";

            List<string> names = new List<string>();
            names.Add("Nila");
            names.Add("Vania");
            names.Add("Arash");
            names.Add("Rosana");

            ViewBag.name = names;

            return View();
        }

        public ActionResult Test(int id=0)
        {
            ViewBag.id = id;
            return View();
        }
    }
}