using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleThreat.Framework.Core
{
    public partial class Document
    {
        public bool Validate()
        {
            if (this.Folder == null || this.Customer == null)
                return false;
            return true;
        }

    }
}
