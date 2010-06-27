using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;

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
            ViewData["Customers"] = RefreshCustomerList();
            return View();
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
        public ActionResult Save(FormCollection formValues)
        {
            Customer customer = CustomerHelper.Instance.CreateCustomer(formValues["CustomerFirstName"].ToString(), formValues["CustomerLastName"].ToString(), formValues["CustomerSSN"].ToString());

            CustomerHelper.Instance.SaveCustomer(customer);

            ViewData["Customers"] = RefreshCustomerList();

            return View("ManageCustomers");
        }
    }
}
