using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;
using TripleThreatWF.Models;

namespace TripleThreatWF.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to TripleThreatWF";

            SearchModel sm = new SearchModel();

            sm.SearchResults = DocumentHelper.Instance.GetAllDocuments();

            ViewData["PartialSM"] = sm;

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
