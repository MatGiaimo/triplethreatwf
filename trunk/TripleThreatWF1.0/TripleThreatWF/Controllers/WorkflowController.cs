using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripleThreatWF.Controllers
{
    public class WorkflowController : Controller
    {
        //
        // GET: /Workflow/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageWorkflow()
        {
            return View();
        }
        public ActionResult NewWorkFlow()
        {
            return View();
        }
        public ActionResult WorkFlowStep()
        {
            return View();
        }


    }
}
