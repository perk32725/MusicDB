using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC1.Controllers
{
    public class MusicDBController : Controller
    {
        /* sample:
        // GET: /<controller>/
        public IActionResult Index() {
            return View();
        }
        */

        // GET: /MusicDB/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /MusicDB/Catalog/
        public IActionResult Catalog()
        {
            ViewData["MainMsg"] = "ViewData['MainMsg']: from Controllers/MusicDBController.cs";
            return View();
        }
    }
}
