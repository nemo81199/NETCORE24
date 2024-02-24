using Microsoft.AspNetCore.Mvc;

namespace LESSON01.MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
