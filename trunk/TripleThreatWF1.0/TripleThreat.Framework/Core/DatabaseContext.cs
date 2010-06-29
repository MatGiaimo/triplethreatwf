using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleThreat.Framework.Core;

namespace TripleThreat.Framework.Core
{
    public partial class DatabaseContext : IDatabaseContext
    {
        #region Properties

        IQueryable<CustomerGroup> IDatabaseContext.CustomerGroups
        {
            get
            {
                return this.CustomerGroups;
            }
        }

        IQueryable<Folder> IDatabaseContext.Folders
        {
            get
            {
                return this.Folders;
            }
        }

        IQueryable<Document> IDatabaseContext.Documents
        {
            get
            {
                return this.Documents;
            }
        }

        IQueryable<Customer> IDatabaseContext.Customers
        {
            get
            {
                return this.Customers;
            }
        }

        IQueryable<Lender> IDatabaseContext.Lenders
        {
            get
            {
                return this.Lenders;
            }
        }

        IQueryable<Address> IDatabaseContext.Addresses
        {
            get
            {
                return this.Addresses;
            }
        }

        IQueryable<WorkFlow> IDatabaseContext.WorkFlows
        {
            get
            {
                return this.WorkFlows;
            }
        }
        #endregion
    }
}
