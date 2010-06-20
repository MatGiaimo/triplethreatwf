using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework;

namespace TripleThreatWF.Controllers
{
    public class DocumentController
    {
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
