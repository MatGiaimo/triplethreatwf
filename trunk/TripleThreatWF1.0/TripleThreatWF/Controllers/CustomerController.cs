using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripleThreatWF.Controllers
{
    public class CustomerController : Controller
    {
        public TripleThreat.Framework.Customer Customer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }

    }
}
