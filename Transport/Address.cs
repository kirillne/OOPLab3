using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public class Address
    {
        public Address()
        {
            State = "";
            Sity = "";
            Street = "";
            Home = "";
        }

        public String State { get; set; }

        public String Sity { get; set; }

        public String Street { get; set; }

        public String Home { get; set; }
    }
}
