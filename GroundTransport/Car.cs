using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.GroundTransports
{
    public class Car : GroundTransport
    {
        public Car(IEngine engine, string stateNumber, 
            int whellCount, bool isDriverNesessary, int doorsCount,
            int seatsCount, int trankSize)
            : base(engine, stateNumber, whellCount, isDriverNesessary, doorsCount)
        {
            TrankSize = trankSize;
            SeatsCount = seatsCount;
        }

        private int seatsCount;

        public int SeatsCount
        {
            get { return seatsCount; }
            set
            {
                if (value < 0) throw new ArgumentException("Seats count must be positive");
                seatsCount = value;
            }
        }

        private int trankSize;

        public int TrankSize
        {
            get { return trankSize; }
            set
            {
                if (value < 0) throw new ArgumentException("Trank must be positive");
                trankSize = value;
            }
        }
    }
}
