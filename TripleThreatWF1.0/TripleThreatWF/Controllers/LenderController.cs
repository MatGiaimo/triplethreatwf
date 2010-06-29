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
    public class LenderController : Controller
    {
        //
        // GET: /Lender/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lenders()
        {
            return View();
        }

        public ActionResult SaveLender(LenderModel cm)
        {
            
            Lender len = LenderHelper.Instance.CreateLender(cm.LenderName);
            
            Address addr = AddressHelper.Instance.CreateAddress(cm.Street, cm.City, cm.State, cm.ZipCode);

            len.Address = addr;
            
            LenderHelper.Instance.SaveLender(len);
    
            return View("Lenders", cm);
        }

    }
}
