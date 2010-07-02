/*
 Copyright (c) 2010 TripleThreatWF

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
*/

using System;
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