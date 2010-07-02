using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using System.ComponentModel.DataAnnotations;

namespace TripleThreatWF.Models
{
    public class SearchModel
    {
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }
        public string CustName { get; set; }
        public string State { get; set; }

        public List<Document> SearchResults { get; set; }
    }
}