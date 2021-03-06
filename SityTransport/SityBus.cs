﻿using System;
using Transports.GroundTransports;

namespace Transports.CityTransports
{
    [Serializable]
    public class SityBus : Bus, ISityTransport
    {
        private int cost;

        public SityBus(Engine engine, string stateNumber, int whellCount,
            bool isDriverNesessary, int doorsCount, int articulationCount,
            int maxPassagersCount, int cost, Route route)
            : base(
                engine, stateNumber, whellCount, isDriverNesessary, doorsCount,
                articulationCount, maxPassagersCount)
        {
            Cost = cost;
            Route = route;
        }


        public SityBus()
        {
            Cost = 10;
            Route = new Route();
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
