using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;

namespace TripleThreatWF.Controllers
{
    public class DocumentController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManageDocument(FormCollection formValues)
        {
            return View();
        }

        public ActionResult Save(IDocument document)
        {
            return View();
        }

    }
}
