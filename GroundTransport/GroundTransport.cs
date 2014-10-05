using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Transports.GroundTransports
{
    public abstract class GroundTransport : Transport
    {
        private int wheelCount;

        protected GroundTransport(IEngine engine, string stateNumber, int whellCount,
            bool isDriverNesessary, int doorsCount)
            : base(engine, stateNumber)
        {
            WheelCount = whellCount;
            if (doorsCount < 1) throw new ArgumentException("Doors count must be positive");
            DoorsCount = doorsCount;
            IsDriverNesessary = isDriverNesessary;
        }

        public int WheelCount
        {
            get { return wheelCount; }
            set
            {
                if(value < 1) throw  new ArgumentException("Whell count must be positive");
                wheelCount = value;
            }
        }

        public int DoorsCount { get; private set; }

        public bool IsDriverNesessary { get; set; }
    }
}
