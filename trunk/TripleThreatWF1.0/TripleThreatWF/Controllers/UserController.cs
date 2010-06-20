using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripleThreatWF.Controllers
{
    public class UserController : Controller
    {
        public TripleThreat.Framework.UserManagement UserManagement
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TripleThreat.Framework.User User
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
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

    }
}
