using Microsoft.AspNetCore.Mvc;

namespace ITFamily.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
