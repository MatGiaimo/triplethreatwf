using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripleThreatWF.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to TripleThreatWF";

            return View();
        }

        public ActionResult OpenItems()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
