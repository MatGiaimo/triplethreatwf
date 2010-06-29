using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;
using System.Data.Entity;

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
        public ActionResult Folder()
        {
            return View();
        }

        public ActionResult ManageFolder()
        {
            //ViewDataDictionary viewData = new ViewDataDictionary();

            ViewData["Folders"] = RefreshFolderList();

            return View();
        }

        public List<Folder> RefreshFolderList()
        {
            List<Folder> folders;

            folders = FolderHelper.Instance.GetAllFolders();

            if (folders != null)
            {
                return folders;
            }
            else
            {
                return new List<Folder>();
            }

        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Save(FormCollection formValues)
        {
            Folder folder = FolderHelper.Instance.CreateFolder(formValues["FolderName"].ToString());

            FolderHelper.Instance.SaveFolder(folder);

            ViewData["Folders"] = RefreshFolderList();

            return View("ManageFolder");
        }

    }
}
