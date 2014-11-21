using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Transports
{
    [Serializable]
    public class SimpleEngine : Engine
    {
        

        public override void Enable()
        {            
        }

        public override void Disable()
        {
        }

        public override int Power { get; set; }
    }
}
