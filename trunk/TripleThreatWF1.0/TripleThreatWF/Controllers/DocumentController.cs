using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;
using TripleThreatWF.Models;
using System.Web.Security;

namespace TripleThreatWF.Controllers
{
    public class DocumentController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManageDocument(DocumentModel dm)
        {
            var postedFile = dm.Image;

            if (postedFile.ContentLength > 0)
            {
            }

            return View();
        }

        public ActionResult ManageDocument()
        {
            DocumentModel dm = new DocumentModel();

            dm.Name = "New Document";

            return View(dm);
        }

        public ActionResult Save(IDocument document)
        {
            return View();
        }

    }
}
