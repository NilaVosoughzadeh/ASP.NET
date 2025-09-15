using Microsoft.AspNetCore.Mvc;

namespace ITFamily.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
