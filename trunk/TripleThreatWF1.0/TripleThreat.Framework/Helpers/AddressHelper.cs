using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleThreat.Framework.Core;

namespace TripleThreat.Framework.Helpers
{
    class AddressHelper : HelperBase
    {
        public static volatile AddressHelper _instance;
        public static object _sync = new Object();

        internal AddressHelper(IDatabaseContext DatabaseConext) : base(DatabaseConext)
        {
        }

        public static AddressHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new AddressHelper(DatabaseContextFactory.Instance.GetDatabaseContext());
                            return _instance;
                        }
                    }
                }

                return _instance;
            }
        }

        public Address CreateAddress(string Street, string City, string State, string Zip)
        {
            Address address = new Address();

            address.Street = Street;
            address.City = City;
            address.State = State;
            address.Zip = Zip;

            return address;
        }
    }
}
