using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.AirTransports
{
    public class Helicopter : AirTransport
    {
        public Helicopter(IEngine engine, string stateNumber, int maxHeight, 
            int runWayLength, int maxWeigth, Screw mainScrew, Screw tailScrew)
            : base(engine, stateNumber, maxHeight, runWayLength, maxWeigth)
        {
            MainScrew = mainScrew;
            TailScrew = tailScrew;
        }

        public Screw MainScrew { get; set; }

        public Screw TailScrew { get; set; }
    }
}
