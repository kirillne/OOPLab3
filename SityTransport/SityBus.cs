using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports.GroundTransports;

namespace Transports.SityTransports
{
    public class SityBus : Bus, ISityTransport
    {
        private int cost;

        public SityBus(IEngine engine, string stateNumber, int whellCount,
            bool isDriverNesessary, int doorsCount, int articulationCount,
            int maxPassagersCount, int cost, Route route)
            : base(
                engine, stateNumber, whellCount, isDriverNesessary, doorsCount,
                articulationCount, maxPassagersCount)
        {
            Cost = cost;
            Route = route;
        }

        public int Cost
        {
            get { return cost; }
            set
            {
                if (value < 0) throw new ArgumentException("Cost must be positive");
                cost = value;
            }
        }

        public Route Route { get; set; }
    }
}
