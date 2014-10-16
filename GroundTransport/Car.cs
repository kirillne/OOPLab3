using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.GroundTransports
{
    [Serializable]
    public class Car : GroundTransport
    {
        public Car(Engine engine, string stateNumber, 
            int whellCount, bool isDriverNesessary, int doorsCount,
            int seatsCount, int trankSize)
            : base(engine, stateNumber, whellCount, isDriverNesessary, doorsCount)
        {
            TrankSize = trankSize;
            SeatsCount = seatsCount;
        }

        public Car()
        {
            TrankSize = 10;
            SeatsCount = 20;
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
