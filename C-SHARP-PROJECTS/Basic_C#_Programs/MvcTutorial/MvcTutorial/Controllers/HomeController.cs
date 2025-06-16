using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTutorial.Models;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\thedi\Documents\Chris\Coding\Logs\log3.txt", text);


            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}


            //return Content("hello");


            //return RedirectToAction("Contact");


            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};


            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;

            
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}