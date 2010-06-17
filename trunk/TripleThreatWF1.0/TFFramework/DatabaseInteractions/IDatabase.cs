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

namespace TripleThreat.Framework.DatabaseInteractions
{
    public interface IDatabase
    {

        // Interactions that involve instances of objects
        #region Instance

        void AddNewDocument(IDocument document);

        void UpdateDocument(IDocument document);

        void ArchiveDocument(IDocument document);


        void AddWorkFlowInstance(IWorkFlow workflow);

        void UpdateWorkFlowInstance(IWorkFlow workflow);

        void DeleteWorkFlowInstance(IWorkFlow workflow);

        
        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(Customer customer);


        void AddCustomerGroup(CustomerGroup customerGroup);

        void UpdateCustomerGroup(CustomerGroup customerGroup);

        void DeleteCustomerGroup(CustomerGroup customerGroup);


        void AddLender(Lender lender);

        void UpdateLender(Lender lender);

        void DeleteLender(Lender lender);


        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);


        void AddUserGroup(UserGroup userGroup);

        void UpdateUserGroup(UserGroup userGroup);

        void DeleteUserGroup(UserGroup userGroup);

        
        List<IDocument> GetDocuments(/*todo: search criterion*/);

        List<IWorkFlowStep> GetWorkFlowSteps(/*todo: search criterion*/);
        
        List<IWorkFlow> GetWorkFlows(/*todo: search criterion*/);


        List<Customer> GetCustomers(/*todo: search criterion*/);

        List<CustomerGroup> GetCustomerGroups(/*todo: search criterion*/);

        List<Lender> GetLenders(/*todo: search criterion*/);


        List<User> GetUsers(/*todo: search criterion*/);

        List<UserGroup> GetUserGroups(/*todo: search criterion*/);

        #endregion Instance


    }
}
