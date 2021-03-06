﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.GroundTransports
{
    [Serializable]
    public class Bus : GroundTransport
    {
        public Bus(Engine engine, string stateNumber,
            int whellCount, bool isDriverNesessary, int doorsCount,
            int articulationCount, int maxPassagersCount)
            : base(engine, stateNumber, whellCount, isDriverNesessary, doorsCount)
        {
            ArticulationCount = articulationCount;
            MaxPassagersCount = maxPassagersCount;
        }

        public Bus()
        {
            ArticulationCount = 1;
            MaxPassagersCount = 80;
        }

        private int articulationCount;

        public int ArticulationCount
        {
            get { return articulationCount; }
            set
            {
                if (value < 0) throw new ArgumentException("Articulation count must be positive");
                articulationCount = value;
            }
        }

        private int maxPassagersCount;

        public int MaxPassagersCount
        {
            get { return maxPassagersCount; }
            set
            {
                if (value < 0) throw new ArgumentException("Max passagers count must be positive");
                maxPassagersCount = value;
            }
        }
    }
}
