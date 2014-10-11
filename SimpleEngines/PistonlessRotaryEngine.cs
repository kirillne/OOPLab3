using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Engines
{
    public class PistonlessRotaryEngine : IEngine
    {
        public PistonlessRotaryEngine(int size, int power)
        {
            Size = size;
            Power = power;
        }

        private bool isInputOpen = false;

        private bool isEnabled = false;

        public void Enable()
        {
            isEnabled = true;
            isInputOpen = true;
        }

        public void Disable()
        {
            isEnabled = false;
            isInputOpen = false;
        }

        public int Size { get; set; }

        public int Power { get; private set; }
    }
}
