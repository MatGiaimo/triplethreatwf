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
using TripleThreat.Framework.Helpers;
using TripleThreatWF.Models;
using System.Web.Security;
using System.IO;

namespace TripleThreatWF.Controllers
{
    public class CustomerController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageCustomer()
        {
            CustomerModel cm = new CustomerModel();

            cm.FirstName = "Enter First Name";
            cm.LastName = "Enter Last Name";
            cm.SSN = "000000000";

            cm.Customers = RefreshCustomerList();

            return View(cm);
            
        }

        public List<Customer> RefreshCustomerList()
        {
            List<Customer> customers;

            customers = CustomerHelper.Instance.GetAllCustomers();

            if (customers != null)
            {
                return customers;
            }
            else
            {
                return new List<Customer>();
            }

        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Save(CustomerModel cm)
        {
            Customer customer = CustomerHelper.Instance.CreateCustomer(cm.FirstName, cm.LastName, cm.SSN);

            CustomerHelper.Instance.SaveCustomer(customer);

            CustomerGroup custgroup = CustomerHelper.Instance.GetCustomerGroupById(cm.CustomerGroup.Id);

            Address addr = AddressHelper.Instance.CreateAddress(cm.Street, cm.City, cm.State, cm.ZipCode);

            customer.Address = addr;

            Lender lender = LenderHelper.Instance.CreateLender(cm.Lender.Name);
                                  
            CustomerHelper.Instance.SaveCustomer(customer);

            cm.Customers = RefreshCustomerList();

            return View("AddCustomer",cm);
        }

        public ActionResult AddCustomer()
        {
            CustomerModel cm = new CustomerModel();
            
            cm.Lenders = LenderHelper.Instance.GetAllLenders();

            cm.CustomerGroups = CustomerHelper.Instance.GetAllCustomerGroups();
            
            return View("AddCustomer",cm);
        }


        public ActionResult SaveCustomer(CustomerModel cm)
        {
            Customer cust = CustomerHelper.Instance.CreateCustomer(cm.FirstName, cm.LastName, cm.SSN);
            
            Address addr = AddressHelper.Instance.CreateAddress(cm.Street, cm.City, cm.State, cm.ZipCode);

            CustomerGroup custgroup = CustomerHelper.Instance.GetCustomerGroupById(cm.CustomerGroup.Id);

            cust.CustomerGroup = custgroup;

            Lender lndr = LenderHelper.Instance.GetLender(cm.Lender.Id);

            cust.Lender = lndr;
            
            cust.Address = addr;
            CustomerHelper.Instance.SaveCustomer(cust);

            cm.Lenders = LenderHelper.Instance.GetAllLenders();

            cm.CustomerGroups = CustomerHelper.Instance.GetAllCustomerGroups();            
            return View("AddCustomer", cm);
        }

        //// new

        public ActionResult ManageGroupID()
        {

            CustomerModel cm = new CustomerModel();

            cm.WorkFlows = WorkFlowHelper.Instance.GetAllWorkFlows();

            return View("ManageGroupID", cm);
        }


        public ActionResult SaveGroupID(CustomerModel cm)
        {
            CustomerGroup cgroup = CustomerHelper.Instance.CreateCustomerGroup(cm.GroupName);

            WorkFlow wflow = WorkFlowHelper.Instance.GetWorkFlow(cm.WorkFlow.Id);

            cgroup.WorkFlow = wflow;
            //cm.WorkFlows = WorkFlowHelper.Instance.GetAllWorkFlows();

            CustomerHelper.Instance.SaveCustomerGroup(cgroup);

            cm.WorkFlows = WorkFlowHelper.Instance.GetAllWorkFlows();


            return View("ManageGroupID", cm);
        }
    }
}
