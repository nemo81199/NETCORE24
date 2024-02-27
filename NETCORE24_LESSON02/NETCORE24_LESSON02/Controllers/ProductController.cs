using Microsoft.AspNetCore.Mvc;
using NETCORE24_LESSON02.Models;

namespace NETCORE24_LESSON02.Controllers
{
    //[Route("danh-sach-san-pham")]
    public class ProductController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            //du lieu tu controler ra view
            ViewBag.Product = "Du lieu trong view bag";
            ViewData["ProductVD"] = "Du lieu trong viewdata -> ProductVD";
            TempData["messageVD"] = "Thong bao du lieu tu tempdata";
            //tra ve view: views/Product/Index.cshtml

            return View();
        }
        public IActionResult GetDetailProduct()
        {
            //du lieu tu controler ra view
            ViewBag.Product = "Du lieu trong view bag";
            ViewData["ProductVD"] = "Du lieu trong viewdata -> ProductVD";
            TempData["messageVD"] = "Thong bao du lieu tu tempdata";
            //tra ve view: views/Product/Index.cshtml

            return View();
        }

        public IActionResult GetProduct()
        {
            //du lieu object
            Product P = new Product()
            {
                id = 1,
                Name = "Test Product"
            };
            ViewBag.product = P;
            return View();
        }

        //[Route("tat-ca")]
        public IActionResult GetAllProduct()
        {
            //Du lieu dang collection
            List<Product> products = new List<Product>()
            {
                new Product() {id =1, Name = "Item 1"},
                new Product() {id =2, Name = "Item 2"},
                new Product() {id =3, Name = "Item 3"},
                new Product() {id =4, Name = "Item 4"},
                new Product() {id =5, Name = "Item 5"},
            };
            ViewData["list"] = products;
            //tra ve view: views/Product/Product.cshtml
            return View("Product");
        }
    }
}
