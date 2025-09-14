using Microsoft.AspNetCore.Mvc;

namespace ITFamily.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
