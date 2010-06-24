using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;

namespace TripleThreatWF.Controllers
{
    public class SearchController : Controller
    {
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
        //
        // GET: /Search/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchDocuments()
        {
            return View();
        }

    }
}
