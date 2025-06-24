using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestPartial()
        {
            ViewBag.Site = "google.com";
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult LoadPartial(int id = 0)
        {
            switch (id)
            {
                case 1:
                    return PartialView("_PartialPage1");
                case 2:
                    return PartialView("_PartialPage2");
                default:
                    return null;
            }
        }
    }
}