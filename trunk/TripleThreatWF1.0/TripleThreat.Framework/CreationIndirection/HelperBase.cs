using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleThreat.Framework.Core;

namespace TripleThreat.Framework.Helpers
{
    public abstract class HelperBase
    {
        public IDatabaseContext _databaseContext;

        protected HelperBase(IDatabaseContext DatabaseContext)
        {
            this._databaseContext = DatabaseContext;
        }

        public IDatabaseContext Database
        {
            get
            {
                return _databaseContext;
            }
        }
    }
}
