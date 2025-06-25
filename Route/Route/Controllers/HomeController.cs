using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("ContactUs")]
        public ActionResult ContactUs()
        {
        return View();
        }

        [Route("AboutUs")]
        public ActionResult AboutUs()
        {
            return View();
        }

        //? for optional
        [Route("Person/{name}/{family?}")]
        public ActionResult ShowPerson(string name , string family)
        {
            ViewBag.Name = name;
            ViewBag.Family = family;
            return View();
        }
    }
}