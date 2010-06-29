using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;

namespace TripleThreatWF.Models
{
    public class SearchModel
    {
        public string Name { get; set; }
        public DateTime? DateAdded { get; set; }
        public string CustName { get; set; }
        public string State { get; set; }

        public List<Document> SearchResults { get; set; }
    }
}