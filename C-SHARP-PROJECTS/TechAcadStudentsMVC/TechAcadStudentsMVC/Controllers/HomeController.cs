using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor localInstructor = new Instructor()
            {
                ID = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(localInstructor);
        }

        public IActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    ID = 1,
                    FirstName = "Kaleb",
                    LastName = "Smith"
                },
                new Instructor()
                {
                    ID = 2,
                    FirstName = "Oliver",
                    LastName = "Jones"
                },
                new Instructor()
                {
                    ID = 3,
                    FirstName = "Parker",
                    LastName = "Johnson"
                }
            };
            return View(instructors);
        }

        public IActionResult Privacy()
        {
            ViewData["School"] = "The Tech Academy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
