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
using System.Data.Objects;

namespace TripleThreat.Framework.Helpers
{
    public class CustomerHelper : HelperBase
    {
        private static volatile CustomerHelper _instance;
        public static object _sync = new Object();

        internal CustomerHelper(IDatabaseContext DatabaseContext)
            : base(DatabaseContext)
        {
        }

        public static CustomerHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new CustomerHelper(DatabaseContextFactory.Instance.GetDatabaseContext());
                            return _instance;
                        }
                    }
                }

                return _instance;
            }
        }

        public Customer CreateCustomer(string FirstName, string LastName, string SSN)
        {
            Customer cust = new Customer();

            cust.FirstName = FirstName;
            cust.LastName = LastName;
            cust.SSN = SSN;

            return cust;
        }

        public List<Customer> GetCustomersForGroup(int CustomerGroupId)
        {
            IQueryable<Customer> custQuery =
                from customer in this.Database.Customers
                where customer.CustomerGroupId == CustomerGroupId
                select customer;

            return custQuery.ToList<Customer>();
        }

        public Customer GetCustomer(int Id)
        {
            IQueryable<Customer> custQuery =
                from customer in this.Database.Customers
                where customer.Id == Id
                select customer;

            Customer cust = custQuery.FirstOrDefault();

            return cust;
        }

        public List<Customer> GetAllCustomers()
        {
            IQueryable<Customer> custQuery =
                from customer in this.Database.Customers
                select customer;

            return custQuery.ToList<Customer>();
        }

        public CustomerGroup GetCustomerGroupById(int Id)
        {
            IQueryable<CustomerGroup> cGroupQuery =
                from customergroup in this.Database.CustomerGroups
                where customergroup.Id == Id
                select customergroup;

            return cGroupQuery.FirstOrDefault();
        }

        public void SaveCustomer(Customer Customer)
        {
            ((DatabaseContext)this.Database).Customers.AddObject(Customer);

            ((DatabaseContext)this.Database).SaveChanges();
        }

    }
}
