using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;
using System.Data.Entity;

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
            List<WorkFlow> workFlows = RefreshWorkFlowList();

            List<string> workFlowList = new List<string>();

            foreach (WorkFlow w in workFlows)
            {
                workFlowList.Add(w.Name);
            }

            ViewData["WorkFlowList"] = new SelectList(workFlowList);
            ViewData["SelectedWorkFlow"] = workFlowList[0];

            return View();
        }
        public ActionResult NewWorkFlow()
        {
            List<Folder> folders = RefreshFolderList();

            List<string> folderList = new List<string>();
            
            foreach (Folder f in folders)
            {
                folderList.Add(f.Name);
            }

            ViewData["FolderList"] =  new SelectList(folderList);

            List<string> stepsList = new List<string>();

            stepsList.Add("step1");
            stepsList.Add("step2");
            stepsList.Add("step3");
            stepsList.Add("autostep1");
            stepsList.Add("autostep2");

            ViewData["StepsList"] = new MultiSelectList(stepsList);

            return View();
        }
        public ActionResult WorkFlowStep()
        {
            return View();
        }

        public List<WorkFlow> RefreshWorkFlowList()
        {
            List<WorkFlow> workFlows;

            workFlows = WorkFlowHelper.Instance.GetAllWorkFlows();

            if (workFlows != null)
            {
                return workFlows;
            }
            else
            {
                return new List<WorkFlow>();
            }

        }

        public List<Folder> RefreshFolderList()
        {
            List<Folder> folders;

            folders = FolderHelper.Instance.GetAllFolders();

            if (folders != null)
            {
                return folders;
            }
            else
            {
                return new List<Folder>();
            }

        }



        public ActionResult HandleForm(string FolderList, string StepsList)
        {
            return View();
        }

        
        public ActionResult HandleWF(string WorkFlowList)
        {
            ViewData["SelectedWorkFlow"] = WorkFlowList;
            
            List<WorkFlow> workFlows = RefreshWorkFlowList();

            List<string> workFlowList = new List<string>();

            foreach (WorkFlow w in workFlows)
            {
                workFlowList.Add(w.Name);
            }

            ViewData["WorkFlowList"] = new SelectList(workFlowList);

            return View("ManageWorkFlow");
        }
    }
}
