using System;
using Transports;

namespace Transports.SityTransports
{
    public interface ISityTransport
    {
        int Cost { get; set; }

        Route Route {get; set;}
    }
}
