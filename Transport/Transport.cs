using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public abstract class Transport
    {
        protected Transport(IEngine engine, String stateNumber)
        {
            Engine = engine;
            StateNumber = stateNumber;
        }
         
        public String StateNumber { get; set; }

        public IEngine Engine { get; private set; }

        public Position CurentPosition { get; protected set; }

        public void TurnOn()
        {
            Engine.Enable();
            isEnabled = true;
        }

        public void TurnOff()
        {
            Engine.Disable();
            isEnabled = false;
        }

        public void GoToPosition(Position position)
        {
            if(!isEnabled) throw new EngineDontStartedExeption();
            CurentPosition = position;
        }

        private bool isEnabled = false;

    }
}
