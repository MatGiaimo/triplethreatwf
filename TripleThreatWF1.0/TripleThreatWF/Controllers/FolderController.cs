/*
 Copyright (c) 2010 TripleThreatWF

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
*/

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
            Document doc = DocumentHelper.Instance.GetDocument(SelectedDocument);

            Models.DocumentModel dm = new Models.DocumentModel();

            dm.Name = doc.Name;
            dm.Id = doc.Id;

            dm.Customer = doc.Customer;
            dm.Customers = CustomerHelper.Instance.GetAllCustomers();

            dm.Folder = doc.Folder;
            dm.Folders = FolderHelper.Instance.GetAllFolders();

            return View("./../Document/ManageDocument", dm);
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
