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
        /*
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        */

        // GET: /MusicDB/

        //public String Index()
        public IActionResult Index()
        {
            /* Normally you would declare a method returning an iActionResult,
             * such as we see above. The normal action is to return View();
             */
            /*
            return "This is the default action in MusicDBController, \n" +
                "It is from /MusicDB.";
             */
            return View();
        }

        // GET: /MusicDB/Catalog/
        public String Catalog()
        {
            return "This is from /MusicDB/Catalog.";
        }
    }
}
