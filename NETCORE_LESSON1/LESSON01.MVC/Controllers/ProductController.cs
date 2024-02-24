using Microsoft.AspNetCore.Mvc;

namespace LESSON01.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
