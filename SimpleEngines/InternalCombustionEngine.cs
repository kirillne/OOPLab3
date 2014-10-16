using Transports;

namespace Engines
{
    public class InternalCombustionEngine : Engine
    {
        private bool isEnabled = false;

        private readonly int power;

        public InternalCombustionEngine()
        {
            this.power = 10;
            CylindersCount = 5;
        }

        public InternalCombustionEngine(int power, int cylindersCount)
        {
            this.power = power;
            CylindersCount = cylindersCount;
        }

        public int CylindersCount { get; set; }

        public override void Enable()
        {
            isEnabled = true;
        }

        public override void Disable()
        {
            isEnabled = false;
        }


        public override int Power
        {
            get { return power; }
        }
    }
}
