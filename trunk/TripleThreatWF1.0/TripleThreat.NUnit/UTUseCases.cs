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

using NUnit.Framework;

using TripleThreat.Framework;

namespace UTTripleThreat
{
    [TestFixture()]
    public class UTUseCases
    {
        [SetUp()]
        public void Init()
        {
        }

        [TearDown()]
        public void Clean()
        {
        }


        #region test cases

        /// <summary>
        /// Create a workflow
        /// </summary>
        [Test]
        public void FuncReq_1()
        {
            List<IWorkFlowStep> steps = new List<IWorkFlowStep>();
            IWorkFlow workflow = WorkFlowHelper.CreateWorkFlow(steps);
        }

        /// <summary>
        /// Create a manual workflow step 
        /// Set a required action on the workflow step
        /// Add a workflow step to a workflow
        /// </summary>
        [Test]
        public void FuncReq_2()
        {

            ManualWorkFlowStep step = new ManualWorkFlowStep();
            step.Action = "Process Loan";

            List<IWorkFlowStep> steps = new List<IWorkFlowStep>();
            steps.Add(step);

            IWorkFlow workflow = WorkFlowHelper.CreateWorkFlow(steps);
        }

        /// <summary>
        /// Create an automated workflow stepAdd an action to the workflow step 
        /// Add a schedule to the action
        /// </summary>
        [Test]
        public void FuncReq_3()
        {
            AutomatedWorkFlowStep step = new AutomatedWorkFlowStep();

            step.Action = AutomatedActions.Complete;
            step.Scheduled = DateTime.Now.Date.AddDays(1);//midnight

            List<IWorkFlowStep> steps = new List<IWorkFlowStep>();
            steps.Add(step);

            IWorkFlow workflow = WorkFlowHelper.CreateWorkFlow(steps);
        }

        /// <summary>
        /// Create a workflow 
        /// Create an automated workflow step 
        /// Add workflow step to workflow 
        /// Create a document 
        /// Assign document to workflow 
        /// execute workflow 
        /// verify workflow is in expected state
        /// </summary>
        [Test]
        public void FuncReq_4()
        {
            IFolder folder = FolderHelper.CreateNewFolder();

            IDocument doc = DocumentHelper.CreateNewDocument();

            folder.AddDocument(doc);

            AutomatedWorkFlowStep step = new AutomatedWorkFlowStep();

            step.Action = AutomatedActions.Complete;
            step.Scheduled = DateTime.Now;

            List<IWorkFlowStep> steps = new List<IWorkFlowStep>();
            steps.Add(step);

            IWorkFlow workflow = WorkFlowHelper.CreateWorkFlow(steps);

            IActivity activity = ActivityHelper.CreateActivity(workflow, new CustomerGroup());

            ActivityHelper.SubmitActivityForProcessing(activity);

            //this would be initiated by another part of system
            AutoStepWorker worker = new AutoStepWorker();
            worker.ExecutedAutomatedTasks();

            //Assert.AreEqual(activity.Status, ActivityStatus.Approved);
        }

        /// <summary>
        /// Create a document 
        /// Add an image to a document
        /// </summary>
        [Test]
        public void FuncReq_5()
        {
            IDocument doc = DocumentHelper.CreateNewDocument();

            doc.UpdateDocument("c:\\some_path_to_a_file");
        }

        /// <summary>
        /// Create a document 
        /// Add attributes to a document: 
        /// Date Added 
        /// Added By 
        /// Document Name 
        /// Customer Name 
        /// State 
        /// View Groups 
        /// Admin Groups
        /// </summary>
        [Test]
        public void FuncReq_6()
        {
        }

        [Test]
        public void FuncReq_7()
        {
        }

        [Test]
        public void FuncReq_8()
        {
        }

        [Test]
        public void FuncReq_9()
        {
        }

        [Test]
        public void FuncReq_10()
        {
        }

        [Test]
        public void FuncReq_11()
        {
        }

        [Test]
        public void FuncReq_12()
        {
        }


        #endregion test cases
    }
}


//[FuncReq_6] Document Attributes

//Create a document 
//Add attributes to a document: 
//Date Added 
//Added By 
//Document Name 
//Customer Name 
//State 
//View Groups 
//Admin Groups
//[FuncReq_7] Document State

//Create a document 
//Verify document is in 'InProgress' or initial state. Do we want an UnAssigned state for documents not belonging to a workflow?
//[FuncReq_8] Document Search
//Specify criteria to search 
//Execute document search. (Document.Find()? IQueryable collection?) We'll be using LINQ to SQL. Not quite sure how to unit test this yet.
//[FuncReq_9] Document Folders
//Create a folder 
//Create two documents 
//Add documents to folder
//[FuncReq_10] User Groups

//Create a Supervisor User Group 
//Create a Technician User Group 
//Create a User 
//Add User to Supervisor Group 
//Add User to Technician Group 
//Verify user has permissions associated with both groups
//[FuncReq_12] Administrators

//Create a Supervisor User Group 
//Create a User 
//Add User to Supervisor Group 
//Remove User from Supervisor Group 
//Remove User
