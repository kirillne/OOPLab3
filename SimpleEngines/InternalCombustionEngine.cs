using Transports;

namespace Engines
{
    public class InternalCombustionEngine : IEngine
    {
        private bool isEnabled = false;

        public InternalCombustionEngine(int power, int cylindersCount)
        {
            Power = power;
            CylindersCount = cylindersCount;
        }

        public int CylindersCount { get; set; }

        public void Enable()
        {
            isEnabled = true;
        }

        public void Disable()
        {
            isEnabled = false;
        }


        public int Power { get; private set; }
    }
}
