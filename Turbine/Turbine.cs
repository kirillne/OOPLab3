using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Engines
{
    [Serializable]
    public class Turbine : Engine
    {
        public Turbine(int shaftCount)
        {
            ShaftCount = shaftCount;
        }

        public Turbine()
        {
            ShaftCount = 5;
        }


        public override void Enable()
        {
            Power++;
        }

        public override void Disable()
        {
            Power = 0;
        }

        public override int Power { get; set; }

        public int ShaftCount { get; set; }
    }
}
