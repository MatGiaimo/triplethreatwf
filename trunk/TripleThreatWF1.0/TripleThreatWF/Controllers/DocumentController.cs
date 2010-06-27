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
        public ActionResult ManageDocument(DocumentModel dm)
        {
            var postedFile = dm.Image;

            if (postedFile.ContentLength > 0)
            {
                int imageLength = postedFile.ContentLength;
                byte[] imageData = new byte[imageLength];
                Stream imageStream = postedFile.InputStream;

                imageStream.Read(imageData, 0, imageLength);

                // update document
                if (dm.Id > 0)
                {
                    Document doc = DocumentHelper.Instance.GetDocument(dm.Id);

                    doc.Name = dm.Name;
                    doc.Customer = dm.Customer;

                    DocumentHelper.Instance.SaveDocument(doc);
                }
                // save new document
                else
                {
                    Document doc = DocumentHelper.Instance.CreateDocument(dm.Name, HttpContext.User.Identity.Name);

                    doc.Image = imageData;
                    doc.CreatedDate = DateTime.UtcNow;
                }

            }

            return View();
        }

        /// <summary>
        /// Action with no parameters
        /// </summary>
        /// <returns></returns>
        public ActionResult ManageDocument()
        {
            DocumentModel dm = new DocumentModel();

            Document doc = DocumentHelper.Instance.CreateDocument("New Document", HttpContext.User.Identity.Name);

            dm.Name = doc.Name;
            dm.Customer = doc.Customer;
            dm.Customers = CustomerHelper.Instance.GetAllCustomers();

            return View(dm);
        }

        //public FileContentResult GetDocumentImage(int DocumentId)
        //{
        //    //SqlDataReader rdr; byte[] fileContent = null;
        //    //string mimeType = ""; string fileName = "";
        //    //const string connect = @"Server=.\SQLExpress;Database=FileTest;Trusted_Connection=True;";

        //    //using (var conn = new SqlConnection(connect))
        //    //{
        //    //    var qry = "SELECT FileContent, MimeType, FileName FROM FileStore WHERE ID = @ID";
        //    //    var cmd = new SqlCommand(qry, conn);
        //    //    cmd.Parameters.AddWithValue("@ID", id);
        //    //    conn.Open();
        //    //    rdr = cmd.ExecuteReader();
        //    //    if (rdr.HasRows)
        //    //    {
        //    //        rdr.Read();
        //    //        fileContent = (byte[])rdr["FileContent"];
        //    //        mimeType = rdr["MimeType"].ToString();
        //    //        fileName = rdr["FileName"].ToString();
        //    //    }
        //    //}

        //    return File(fileContent, mimeType, fileName);
        //}


        public ActionResult Save(IDocument document)
        {
            // set created date and save
            return View();
        }

    }
}
