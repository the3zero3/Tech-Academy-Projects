using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
