using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.AirTransports
{
    public class Screw
    {
        private int bladeLength;

        private int bladeCount;
        
        public Screw(int bladeCount, int bladeLength)
        {
            BladeCount = bladeCount;

            BladeLength = bladeLength;
        }

        public int BladeCount
        {
            get { return bladeCount; }
            set
            {
                if (value < 1) throw new ArgumentException("Blade count must be positive");
                bladeCount = value;
            }
        }

        public int BladeLength
        {
            get { return bladeLength; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Blade length must be positive");
                bladeLength = value;
            }
        }
    }
}
