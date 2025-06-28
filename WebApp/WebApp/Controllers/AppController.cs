using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class AppController : Controller
    {
        public string HiMVC()
        {
            return "Hello World";
        }
        public string ShowDateTime()
        {
            return DateTime.Now.ToString();
        }
        public string Step1()
        {
            return "<h1>Nila</h1>";
        }
    }
}