using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public class Position
    {
        public Address Address { get; set; }

        public String Name { get; set; }

        public Position(Address address, String name)
        {
            this.Address = address;
            this.Name = name;
        }

        public Position()
        {
            this.Address = new Address();
            this.Name = "Empty";
        }
    }
}
