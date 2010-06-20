using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleThreat.Framework
{
    public class Address
    {
        public Address(string Street, string City, string State, string Zip)
        {
            this.Street = Street;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
