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
        public Customer Customer
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

            Address addr = AddressHelper.Instance.CreateAddress(cm.Street, cm.City, cm.State, cm.ZipCode);

            customer.Address = addr;

            Lender lender = LenderHelper.Instance.CreateLender(cm.Lender.Name);
          
           
            CustomerHelper.Instance.SaveCustomer(customer);

            cm.Customers = RefreshCustomerList();

            return View(cm);
        }

        public ActionResult AddCustomer()
        {
            CustomerModel cm = new CustomerModel();

            cm.Lenders = LenderHelper.Instance.GetAllLenders();

            return View(cm);
        }

        public ActionResult SaveCustomer(CustomerModel cm)
        {
            Customer cust = CustomerHelper.Instance.CreateCustomer(cm.FirstName, cm.LastName, cm.SSN);
            cust.Address = cust.Address;
            Address addr = AddressHelper.Instance.CreateAddress(cm.Street, cm.City, cm.State, cm.ZipCode);
                        
            return View("AddCustomer", cm);
        }

        //[HttpPost]
        //public ActionResult Save(RegisterModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Attempt to register the customer
        //        MembershipCreateStatus createStatus =  MembershipService.CreateUser(model.UserName, model.Password, model.Email);

        //        if (createStatus == MembershipCreateStatus.Success)
        //        {
        //            FormsService.SignIn(model.UserName, false /* createPersistentCookie */);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", AccountValidation.ErrorCodeToString(createStatus));
        //        }
        //    }

        //    // If we got this far, something failed, redisplay form
        //    ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
        //    return View(model);
        //}
    }
}
