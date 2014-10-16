using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Engines
{
    public class PistonlessRotaryEngine : Engine
    {
        public PistonlessRotaryEngine(int size, int power)
        {
            Size = size;
            this.power = power;
        }

        public PistonlessRotaryEngine()
        {
            Size = 100;
            this.power = 10;
        }

        private bool isInputOpen = false;

        private bool isEnabled = false;
        private int power;

        public override void Enable()
        {
            isEnabled = true;
            isInputOpen = true;
        }

        public override void Disable()
        {
            isEnabled = false;
            isInputOpen = false;
        }

        public  int Size { get; set; }

        public override int Power
        {
            get { return power; }
           
        }
    }
}
