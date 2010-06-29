using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;

namespace TripleThreatWF.Models
{
    public class LenderModel
    {
        public string LenderName { get; set; }
        public string AccountNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Lender Lender { get; set; }
        public List<Lender> Lenders { get; set; }
    }
}