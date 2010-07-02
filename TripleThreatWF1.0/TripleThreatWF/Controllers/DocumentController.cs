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
using TripleThreatWF.Models;
using System.Web.Security;
using System.IO;

namespace TripleThreatWF.Controllers
{
    public class DocumentController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Post/Update of document data including image
        /// </summary>
        /// <param name="dm"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Save(DocumentModel dm)
        {
            var postedFile = dm.Image;
            Document doc = new Document();

            if (postedFile != null)
            {
                if (postedFile.ContentLength > 0)
                {
                    int imageLength = postedFile.ContentLength;
                    byte[] imageData = new byte[imageLength];
                    Stream imageStream = postedFile.InputStream;

                    imageStream.Read(imageData, 0, imageLength);

                    // update document
                    if (dm.Id > 0)
                    {
                        doc = DocumentHelper.Instance.GetDocument(dm.Id);

                        doc.Name = dm.Name;

                        
                        dm.Customer = CustomerHelper.Instance.GetCustomer(dm.Customer.Id);
                        
                        dm.Folder = FolderHelper.Instance.GetFolder(dm.Folder.Id);

                        doc.Customer = dm.Customer;
                        doc.Folder = dm.Folder;

                        doc.Image = imageData;
                        doc.ImageName = postedFile.FileName;
                        doc.ImageMime = postedFile.ContentType;

                        if (doc.Validate())
                        {
                            doc = DocumentHelper.Instance.SaveDocument(doc);
                        }
                    }
                    // save new document
                    else
                    {
                        doc = DocumentHelper.Instance.CreateDocument(dm.Name, HttpContext.User.Identity.Name);

                        doc.Name = dm.Name;

                        dm.Customer = CustomerHelper.Instance.GetCustomer(dm.Customer.Id);
                        dm.Folder = FolderHelper.Instance.GetFolder(dm.Folder.Id);

                        doc.Customer = dm.Customer;
                        doc.Folder = dm.Folder;

                        doc.Image = imageData;
                        doc.ImageName = postedFile.FileName;
                        doc.ImageMime = postedFile.ContentType;
                        doc.CreatedDate = DateTime.UtcNow;

                        if (doc.Validate())
                        {
                            doc = DocumentHelper.Instance.SaveDocument(doc);
                        }
                    }
                }
            }

            dm.Id = doc.Id;
            dm.Name = doc.Name;
            dm.Customers = CustomerHelper.Instance.GetAllCustomers();
            dm.Folders = FolderHelper.Instance.GetAllFolders();

            return View("ManageDocument",dm);
        }



        /// <summary>
        /// Action with no parameters
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateDocument()
        {
            DocumentModel dm = new DocumentModel();

            Document doc = DocumentHelper.Instance.CreateDocument("New Document", HttpContext.User.Identity.Name);

            dm.Name = doc.Name;
            dm.Customer = doc.Customer;
            dm.Customers = CustomerHelper.Instance.GetAllCustomers();
            dm.Folder = doc.Folder;
            dm.Folders = FolderHelper.Instance.GetAllFolders();

            return View("ManageDocument",dm);
        }

        public ActionResult ManageDocument(string Id)
        {
            DocumentModel dm = new DocumentModel();

            Document doc = DocumentHelper.Instance.GetDocument(Convert.ToInt32(Id));

            dm.Name = doc.Name;
            dm.Id = doc.Id;

            dm.Customer = doc.Customer;
            dm.Customers = CustomerHelper.Instance.GetAllCustomers();

            dm.Folder = doc.Folder;
            dm.Folders = FolderHelper.Instance.GetAllFolders();

            return View("ManageDocument", dm);
        }

        public FileContentResult GetDocumentImage(string Id)
        {
            Document doc = DocumentHelper.Instance.GetDocument(Convert.ToInt32(Id));

            return File(doc.Image, doc.ImageMime, doc.ImageName);
        }
    }
}
