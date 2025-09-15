using Microsoft.AspNetCore.Mvc;

namespace ITFamily.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
