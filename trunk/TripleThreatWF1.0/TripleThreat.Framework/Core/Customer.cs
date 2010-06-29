using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleThreat.Framework.Core
{
    public partial class Customer
    {
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
    }
}
