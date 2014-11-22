using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyLoader;

namespace CustomConverters
{
    public class CustomXmlJsonConverter : IConverter
    {
        public string ConvertInput(string sourse)
        {
            return CustomJsonToXmlConverter.Convert(sourse);
        }

        public string ConvertOutput(string sourse)
        {
            return CustomXmlToJsonConverter.Convert(sourse);
        }
    }
}
