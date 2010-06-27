using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripleThreatWF.Models
{
    public class DocumentModel
    {
        // User name
        public String Name { get; set; }
        // User email address
        public DateTime CreatedDate { get; set; }
        // Reference to the uploaded file
        public HttpPostedFileBase Image { get; set; }
    }
}