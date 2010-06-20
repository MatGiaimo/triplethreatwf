using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripleThreatWF.Controllers
{
    public class SearchController : Controller
    {
        public TripleThreat.Framework.DocumentHelper DocumentHelper
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TripleThreat.Framework.IDocument IDocument
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
