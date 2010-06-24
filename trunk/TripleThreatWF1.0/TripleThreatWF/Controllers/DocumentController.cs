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
        public IDocument IDocument
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DocumentHelper DocumentHelper
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //
        // GET: /Document/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageDocument()
        {
            return View();
        }

        public ActionResult Save(IDocument document)
        {
            return View();
        }

    }
}
