using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    class EngineDontStartedExeption : Exception
    {
        public EngineDontStartedExeption(String message) : base(message)
        {
        }

        public EngineDontStartedExeption(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        public EngineDontStartedExeption()
        {
            base.Message = "Engine don't started";
        }
    }
}
