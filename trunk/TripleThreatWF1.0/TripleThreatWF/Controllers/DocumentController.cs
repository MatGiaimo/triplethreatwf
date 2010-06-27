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

                }
                // save new document
                else
                {
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

            dm.Name = "New Document";

            return View(dm);
        }

        /// <summary>
        /// Action with querystring containing document id.  Refreshes document from database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult ManageDocument(string Id)
        {
            return View();
        }

        public ActionResult Save(IDocument document)
        {
            return View();
        }

    }
}
