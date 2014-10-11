using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.AirTransports
{
    public class Plane : AirTransport
    {
        public Plane(IEngine engine, string stateNumber, int maxHeight, int runWayLength,
            int maxWeigth, Wing wingType, bool isWaterNesessary)
            : base(engine, stateNumber, maxHeight, runWayLength, maxWeigth)
        {
            WingType = wingType;
            IsWaterNesessary = isWaterNesessary;
        }


        public Wing WingType { get; set; }

        public bool IsWaterNesessary { get; set; }
    }
}
