using Microsoft.AspNetCore.Mvc;
using NETCORE24_LESSON2_LAB.Models;
namespace NETCORE24_LESSON2_LAB.Controllers
{
    public class ProductController : Controller
    {
        [Route("san-pham")]
        public IActionResult Index()
        {
            var cate = CATOGERI();
            ViewData["list"] = cate;
            return View();
        }

        [Route("chi-tiet-san-pham",Name = "detailProduct")]
        public IActionResult GetDetailProduct(int id)
        {
            var cate = CATOGERI();
            Category newcate = cate.FirstOrDefault(ac => ac.Id == id);
            ViewBag.cate = newcate;
            return View();
        }

        public List<Category> CATOGERI()
        {
            List<Category> cate = new List<Category>()
            {
                new Category {Id=1,Name="Ao uniqlo 1",Images = "~/images/test1.webp", Price = 1000000, SalePrice = 50000, CategoryId = 1, Description = "Uniqloaaaadddddđ  ddđ", Status = "1", CreatedAt = "01/02/2023 2.03.22"},
                new Category {Id=2,Name="Ao uniqlo 2",Images = "~/images/test2.webp", Price = 2000000, SalePrice = 20000, CategoryId = 2, Description = "Uniqlobbbb dđ", Status = "1", CreatedAt = "05/02/2023 2.03.22"},
                new Category {Id=3,Name="Ao uniqlo 3",Images = "~/images/test3.jpg", Price = 3000000, SalePrice = 30000, CategoryId = 1, Description = "Uniqlocccccccccc vvvvv", Status = "0", CreatedAt = "12/10/2023 2.03.22"},
                new Category {Id=4,Name="Ao uniqlo 4",Images = "~/images/test4.webp", Price = 4000000, SalePrice = 10000, CategoryId = 2, Description = "Uniqloddddđvvv", Status = "1", CreatedAt = "19/05/2023 2.03.22"},
            };
            return cate;
        }
    }
}
