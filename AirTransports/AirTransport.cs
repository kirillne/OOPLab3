using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.AirTransports
{
    public abstract class AirTransport :Transport
    {
        private int runWayLength;
        
        private int maxWeigth;
        
        private int maxHeigth;

        protected AirTransport(IEngine engine, string stateNumber, int maxHeight,
            int runWayLength, int maxWeigth) : base(engine, stateNumber)
        {
            MaxHeigth = maxHeight;
            MaxWeigth = maxWeigth;
            RunWayLength = runWayLength;
        }

        public int MaxHeigth
        {
            get { return maxHeigth; }
            set
            {
                if (value < 1) throw new ArgumentException("Max heigth count must be positive");
                maxHeigth = value;
            }
        }

        public int MaxWeigth
        {
            get { return maxWeigth; }
            set
            {
                if (value < 1) throw new ArgumentException("Max weigth count must be positive");
                maxWeigth = value;
            }
        }

        public int RunWayLength
        {
            get { return runWayLength; }
            set
            {
                if (value < 0) throw new ArgumentException("Runway length count must be positive");
                runWayLength = value;
            }
        }
    }
}
