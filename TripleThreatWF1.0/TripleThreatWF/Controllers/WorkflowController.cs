﻿/*
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

            ViewData["WorkFlows"] = workFlows;

            return View();
        }
        public ActionResult NewWorkFlow()
        {
            List<Folder> folders = RefreshFolderList();
            List<Lender> lenders = LenderHelper.Instance.GetAllLenders();

            ViewData["FolderList"] = folders;
            ViewData["LenderList"] = lenders;

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
                workFlowList.Add(w.Id.ToString() + ":" + w.Name);
            }

            ViewData["WorkFlowList"] = new SelectList(workFlowList);

            return View("OpenWorkFlow");
        }

        public ActionResult HandleRadio(int SelectedWorkFlow)
        {
            ViewData["SelectedWorkFlow"] = WorkFlowHelper.Instance.GetWorkFlow(SelectedWorkFlow);
            return View("OpenWorkFlow");
        }

        public ActionResult HandleWFStep(int SelectedWorkFlowStep, int Id)
        {
            WorkFlow w = WorkFlowHelper.Instance.GetWorkFlow(Id);

            foreach (WorkFlowStep s in w.WorkFlowSteps)
            {
                if (s.Id == SelectedWorkFlowStep)
                    s.IsComplete = true;
            }
            WorkFlowHelper.Instance.SaveWorkFlow(w);

            ViewData["SelectedWorkFlow"] = WorkFlowHelper.Instance.GetWorkFlow(Id);
            return View("OpenWorkFlow");
        }

        public ActionResult HandleWFFolder(int Id)
        {
            ViewData["CurrentFolder"] = WorkFlowHelper.Instance.GetWorkFlow(Id).Folder;
            return View("./../Folder/OpenFolder");
        }

        public ActionResult CreateWorkFlow(string name, bool scanning, bool verifying, bool creditcheck, int SelectedFolder, int SelectedLender)
        {
            List<WorkFlowStep> steps = new List<WorkFlowStep>();

            if (scanning)
            {
                steps.Add(WorkFlowHelper.Instance.CreateWorkFlowStep("Scanning", false));
            }

            if (scanning)
            {
                steps.Add(WorkFlowHelper.Instance.CreateWorkFlowStep("Verifying", false));
            }

            if (scanning)
            {
                steps.Add(WorkFlowHelper.Instance.CreateWorkFlowStep("CreditCheck", false));
            }

            WorkFlow w = WorkFlowHelper.Instance.CreateWorkFlow(name, steps);
            w.Folder = FolderHelper.Instance.GetFolder(SelectedFolder);
            w.Lender = LenderHelper.Instance.GetLender(SelectedLender);

            WorkFlowHelper.Instance.SaveWorkFlow(w);

            List<WorkFlow> workFlows = RefreshWorkFlowList();

            ViewData["WorkFlows"] = workFlows;

            return View("ManageWorkflow");
        }
    }
}
