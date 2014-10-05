using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public interface IEngine
    {
        void Enable();

        void Disable();

        int Power { get; }

    }
}
