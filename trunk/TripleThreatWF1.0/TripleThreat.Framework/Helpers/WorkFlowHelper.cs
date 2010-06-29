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
using System.Text;
using TripleThreat.Framework.Core;

namespace TripleThreat.Framework.Helpers
{
    public class WorkFlowHelper : HelperBase
    {
        private static volatile WorkFlowHelper _instance;
        public static object _sync = new Object();

        internal WorkFlowHelper(IDatabaseContext DatabaseContext)
            : base(DatabaseContext)
        {
        }

        public static WorkFlowHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new WorkFlowHelper(DatabaseContextFactory.Instance.GetDatabaseContext());
                            return _instance;
                        }
                    }
                }

                return _instance;
            }
        }

        public WorkFlow CreateWorkFlow(string name, List<WorkFlowStep> steps)
        {
            WorkFlow w = new WorkFlow();

            w.Name = name;
            foreach( WorkFlowStep s in steps)
            {
                w.WorkFlowSteps.Add(s);
            }

            return w;
        }

        public WorkFlow GetWorkFlow(int Id)
        {
            IQueryable<WorkFlow> wfQuery =
                from workflow in this.Database.WorkFlows
                where workflow.Id == Id
                select workflow;

            return wfQuery.FirstOrDefault();
        }

        public List<WorkFlow> GetAllWorkFlows()
        {
            IQueryable<WorkFlow> wfQuery =
                from workflow in this.Database.WorkFlows
                select workflow;

            return wfQuery.ToList<WorkFlow>();
        }

        public WorkFlowStep GetCurrentWorkFlowStep(WorkFlow workflow)
        {
            foreach (WorkFlowStep s in workflow.WorkFlowSteps)
            {
                if (!s.IsComplete) return s;
            }

            return null;
        }


        public void SaveWorkFlow(WorkFlow workflow)
        {
            //if (((DatabaseContext)this.Database).WorkFlows.Contains<WorkFlow>(workflow))
            //{
            //    ((DatabaseContext)this.Database).WorkFlows.DeleteObject(workflow);
            //}

            ((DatabaseContext)this.Database).WorkFlows.AddObject(workflow);

            ((DatabaseContext)this.Database).SaveChanges();
        }
    }
}

