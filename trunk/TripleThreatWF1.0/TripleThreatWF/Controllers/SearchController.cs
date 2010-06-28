using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;
using TripleThreatWF.Models;

namespace TripleThreatWF.Controllers
{
    public class SearchController : Controller
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
        //
        // GET: /Search/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchDocuments(SearchModel sm)
        {
            if (string.IsNullOrEmpty(sm.CustName) && sm.DateAdded == DateTime.MinValue &&
                string.IsNullOrEmpty(sm.Name))
            {
                sm.SearchResults = new List<Document>();
            }
            else
            {
                sm.SearchResults = DocumentHelper.Instance.SearchDocuments(sm.Name, sm.CustName, sm.DateAdded, sm.State);
            }

            return View(sm);
        }

        public ActionResult OpenItems(SearchModel sm)
        {
            sm.SearchResults = DocumentHelper.Instance.GetAllDocuments();

            return View(sm);
        }

    }
}
