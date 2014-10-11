using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Engines
{
    public class Turbine : IEngine
    {

        public Turbine(int shaftCount)
        {
            ShaftCount = shaftCount;
        }

        public void Enable()
        {
            Power++;
        }

        public void Disable()
        {
            Power = 0;
        }

        public int Power { get; private set; }

        public int ShaftCount { get; set; }
    }
}
