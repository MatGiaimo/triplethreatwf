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

        #endregion
    }
}
