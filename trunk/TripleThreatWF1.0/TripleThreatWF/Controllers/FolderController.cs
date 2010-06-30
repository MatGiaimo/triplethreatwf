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

        public ActionResult OpenFolder()
        {
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

        public ActionResult HandleRadio(int SelectedFolder)
        {
            ViewData["CurrentFolder"] = FolderHelper.Instance.GetFolder(SelectedFolder);

            return View("OpenFolder");
        }

        public ActionResult HandleDocumentRadio(int SelectedDocument, int Id)
        {
            ViewData["CurrentDocument"] = DocumentHelper.Instance.GetDocument(SelectedDocument);

            return View("OpenDocument");
        }

        public ActionResult AddDocument(int Id)
        {
            Folder CurrentFolder = FolderHelper.Instance.GetFolder(Id);
            List<Document> docs = DocumentHelper.Instance.GetAllDocuments();

            foreach (Document d in CurrentFolder.Documents)
            {
                for (int i = 0; i < docs.Count; ++i)
                {
                    if (d.Id == docs[i].Id)
                    {
                        docs.RemoveRange(i, 1);
                        --i;
                    }
                }
            }

            ViewData["Documents"] = docs;
            ViewData["CurrentFolder"] = CurrentFolder;

            return View("AddDocuments");
        }

        public ActionResult AddDocumentRadio(int SelectedDocument, int Id)
        {
            Folder CurrentFolder = FolderHelper.Instance.GetFolder(Id);
            CurrentFolder.Documents.Add(DocumentHelper.Instance.GetDocument(SelectedDocument));
            
            List<Document> docs = DocumentHelper.Instance.GetAllDocuments();

            foreach (Document d in CurrentFolder.Documents)
            {
                for (int i = 0; i < docs.Count; ++i)
                {
                    if (d.Id == docs[i].Id)
                    {
                        docs.RemoveRange(i, 1);
                        --i;
                    }
                }
            }

            ViewData["Documents"] = docs;
            ViewData["CurrentFolder"] = CurrentFolder;

            return View("AddDocuments");
        }

        public ActionResult AddDocumentDone(int Id)
        {
            ViewData["CurrentFolder"] = FolderHelper.Instance.GetFolder(Id);

            return View("OpenFolder");
        }
    }
}
