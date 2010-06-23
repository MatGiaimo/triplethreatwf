using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleThreat.Framework.DatabaseInteractions
{
    public partial class DatabaseContext : IDatabaseContext
    {
        // Interactions that involve instances of objects
        #region Instance

        public void AddNewDocument(IDocument document)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDocument(IDocument document)
        {
            throw new System.NotImplementedException();
        }

        public void ArchiveDocument(IDocument document)
        {
            throw new System.NotImplementedException();
        }


        public void AddWorkFlowInstance(IWorkFlow workflow)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateWorkFlowInstance(IWorkFlow workflow)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteWorkFlowInstance(IWorkFlow workflow)
        {
            throw new System.NotImplementedException();
        }


        public void AddCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }


        public void AddCustomerGroup(CustomerGroup customerGroup)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomerGroup(CustomerGroup customerGroup)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomerGroup(CustomerGroup customerGroup)
        {
            throw new System.NotImplementedException();
        }


        public void AddLender(Lender lender)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLender(Lender lender)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLender(Lender lender)
        {
            throw new System.NotImplementedException();
        }


        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }


        public void AddUserGroup(UserGroup userGroup)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUserGroup(UserGroup userGroup)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUserGroup(UserGroup userGroup)
        {
            throw new System.NotImplementedException();
        }


        public List<IDocument> GetDocuments(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }

        public List<IWorkFlowStep> GetWorkFlowSteps(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }

        public List<IWorkFlow> GetWorkFlows(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }


        // Move these methods to 'Helpers'? expose only instances of helpers?
        public List<Customer> GetCustomers(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }

        public List<CustomerGroup> GetCustomerGroups(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }

        public List<Lender> GetLenders(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }


        public List<User> GetUsers(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }

        public List<UserGroup> GetUserGroups(/*todo: search criterion*/)
        {
            throw new System.NotImplementedException();
        }

        #endregion Instance
    }
}
