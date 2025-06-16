using Microsoft.AspNetCore.Mvc;

namespace TechAcadStudentsMVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
