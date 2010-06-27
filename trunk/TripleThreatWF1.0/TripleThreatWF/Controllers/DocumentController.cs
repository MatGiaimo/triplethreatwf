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

            if (postedFile.ContentLength > 0)
            {
                int imageLength = postedFile.ContentLength;
                byte[] imageData = new byte[imageLength];
                Stream imageStream = postedFile.InputStream;

                imageStream.Read(imageData, 0, imageLength);

                Document doc = new Document();

                // update document
                if (dm.Id > 0)
                {
                    doc = DocumentHelper.Instance.GetDocument(dm.Id);

                    doc.Name = dm.Name;

                    doc.Customer = CustomerHelper.Instance.GetCustomer(dm.Customer.Id);

                    doc.Customer = dm.Customer;
                    doc.Image = imageData;
                    doc.ImageName = postedFile.FileName;
                    doc.ImageMime = postedFile.ContentType;

                    doc = DocumentHelper.Instance.SaveDocument(doc);
                }
                // save new document
                else
                {
                    doc = DocumentHelper.Instance.CreateDocument(dm.Name, HttpContext.User.Identity.Name);

                    doc.Name = dm.Name;

                    doc.Customer = CustomerHelper.Instance.GetCustomer(dm.Customer.Id);

                    doc.Image = imageData;
                    doc.ImageName = postedFile.FileName;
                    doc.ImageMime = postedFile.ContentType;
                    doc.CreatedDate = DateTime.UtcNow;

                    doc = DocumentHelper.Instance.SaveDocument(doc);
                }

                dm.Id = doc.Id;
            }

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

            return View("ManageDocument", dm);
        }

        public FileContentResult GetDocumentImage(int DocumentId)
        {
            Document doc = DocumentHelper.Instance.GetDocument(DocumentId);

            return File(doc.Image, doc.ImageMime, doc.ImageName);
        }
    }
}
