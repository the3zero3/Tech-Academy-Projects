using System.Diagnostics;
using FinalChallengeAssignment.Data;
using FinalChallengeAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalChallengeAssignment.Controllers
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
            using (var ctx = new StudentContext())
            {
                var stud = new Student()
                {
                    FirstName = "Jimbo",
                    LastName = "Jones",
                    GPA = 4.0m
                };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
