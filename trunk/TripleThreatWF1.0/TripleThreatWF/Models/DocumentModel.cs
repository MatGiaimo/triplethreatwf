using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;

namespace TripleThreatWF.Models
{
    public class DocumentModel
    {
        // Document Id
        public int Id { get; set; }
        // Document name
        public String Name { get; set; }
        // Document Created date
        public DateTime CreatedDate { get; set; }
        // Customer
        public Customer Customer { get; set; }
        // All customers
        public List<Customer> Customers { get; set; }
        // Reference to the uploaded file
        public HttpPostedFileBase Image { get; set; }
    }
}