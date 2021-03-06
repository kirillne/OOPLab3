﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Engines
{
    [Serializable]
    public class PistonlessRotaryEngine : Engine
    {
        public PistonlessRotaryEngine(int size, int power)
        {
            Size = size;
            this.Power = power;
        }

        public PistonlessRotaryEngine()
        {
            Size = 100;
            this.Power = 10;
        }

        private bool isInputOpen = false;

        private bool isEnabled = false;

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

        public override int Power { get; set; }
    }
}
