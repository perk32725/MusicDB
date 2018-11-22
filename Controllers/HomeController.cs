using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        // calls Views/Home/Index.cshtml:
        public IActionResult Index()
        {
            return View();
        }

        // calls Views/Home/About.cshtml:
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // calls Views/Home/Contact.cshtml:
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        // calls Views/Home/Privacy.cshtml:
        public IActionResult Privacy()
        {
            return View();
        }

        // Don't know what this does:
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        // calls Views/Shared/Error.cshtml:
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
