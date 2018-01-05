using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWebUI.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "HomeController.Index called!";
        //}

		public IActionResult Index()
        {
            //return "HomeController.Index called!";
            //ViewBag.Message = "ViewBag is a dynamic object!";
            //var model = new string[] { "Red", "Green", "Blue" };
            //return View(model);

			IList<Student> studentList = new List<Student>();
            studentList.Add(new Student("Mary", "Haas"));
            studentList.Add(new Student("Steven", "Pinker"));
            studentList.Add(new Student("David", "Hume"));
            ViewData["students"] = studentList;

            ViewBag.Quote = "A rose by any other name would smell as sweet";
            ViewBag.Author = "William Shakespeare";

            var model = new Course[] {
                new Course("Epistemology", 3),
                new Course("Psycholinguistics", 6),
                new Course("Aristotelian Logic", 3) };

            return View(model);
        }
    }
}
