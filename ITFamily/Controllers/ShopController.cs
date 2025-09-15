using Microsoft.AspNetCore.Mvc;

namespace ITFamily.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
