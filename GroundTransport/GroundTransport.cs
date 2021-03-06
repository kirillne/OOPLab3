﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;

namespace Transports.GroundTransports
{
    [Serializable]
    public abstract class GroundTransport : Transport
    {
        private int wheelCount;

        protected GroundTransport(Engine engine, string stateNumber, int whellCount,
            bool isDriverNesessary, int doorsCount)
            : base(engine, stateNumber)
        {
            WheelCount = whellCount;
            if (doorsCount < 1) throw new ArgumentException("Doors count must be positive");
            DoorsCount = doorsCount;
            IsDriverNesessary = isDriverNesessary;
        }

        protected GroundTransport() 
        {
            WheelCount = 4;
            DoorsCount = 5;
            IsDriverNesessary = true;
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

        public int DoorsCount { get;  set; }

        public bool IsDriverNesessary { get; set; }
    }
}
