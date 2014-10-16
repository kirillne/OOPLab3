using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Engines
{
    public class Turbine : Engine
    {
        private int power;

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
            power++;
        }

        public override void Disable()
        {
            power = 0;
        }

        public override int Power
        {
            get { return power; }
        }

        public int ShaftCount { get; set; }
    }
}
