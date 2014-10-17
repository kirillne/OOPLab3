using System;

namespace Transports.CityTransports
{
    [Serializable]
    public class TrolleyBus : SityBus
    {
        private int autonomicWorkTime;

        public TrolleyBus(Engine engine, string stateNumber, int whellCount,
            bool isDriverNesessary, int doorsCount, int articulationCount,
            int maxPassagersCount, int cost, Route route, int autonomicWorkTime)
            : base(
                engine, stateNumber, whellCount, isDriverNesessary, doorsCount,
                articulationCount, maxPassagersCount, cost, route)
        {
            AutonomicWorkTime = autonomicWorkTime;
        }

        public TrolleyBus()
        {
            AutonomicWorkTime = 50;
        }


        public int AutonomicWorkTime
        {
            get { return autonomicWorkTime; }
            set
            {
                if (autonomicWorkTime < 0)
                    throw new ArgumentException(
                        "Autonomic work time must be positive");
                autonomicWorkTime = value;
            }
        }
    }
}
