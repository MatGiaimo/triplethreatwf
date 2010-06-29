using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;

namespace TripleThreatWF.Models
{
    public class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }      
        public List<Customer> Customers { get; set; }
        public Lender Lender { get; set; }
        public List<Lender> Lenders { get; set; }
        public CustomerGroup CustomerGroup { get; set; }
        public List<CustomerGroup> CustomerGroups { get; set; }

    }
}