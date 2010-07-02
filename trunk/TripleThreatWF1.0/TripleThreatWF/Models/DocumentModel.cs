﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using System.ComponentModel.DataAnnotations;

namespace TripleThreatWF.Models
{
    public class DocumentModel
    {
        // Document Id
        public int Id { get; set; }
        // Document name
        [Required]
        public String Name { get; set; }
        // Document Created date
        public DateTime CreatedDate { get; set; }
        // Customer
        public Customer Customer { get; set; }
        // All customers
        public List<Customer> Customers { get; set; }
        // Folder
        public Folder Folder { get; set; }
        // All Folders
        public List<Folder> Folders { get; set; }
        // Reference to the uploaded file
        [Required]
        public HttpPostedFileBase Image { get; set; }
        // Image Name
        public string ImageName { get; set; }
        // Image Mime
        public string ImageMime { get; set; }
    }
}