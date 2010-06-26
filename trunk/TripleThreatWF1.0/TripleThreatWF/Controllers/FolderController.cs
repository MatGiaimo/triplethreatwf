using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;

namespace TripleThreatWF.Controllers
{
    public class FolderController : Controller
    {
        public IFolder IFolder
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
        // GET: /Folder/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageFolder()
        {
            return View();
        }

    }
}
