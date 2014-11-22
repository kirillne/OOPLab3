using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AssemblyLoader;

namespace NewtonsoftConverter
{
    public class NewtonsoftJsonXmlConverter : IConverter
    {
        public string ConvertInput(string sourse)
        {
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            {
                Newtonsoft.Json.JsonConvert.DeserializeXmlNode(sourse).WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                return stringWriter.GetStringBuilder().ToString();
            }

        }

        public string ConvertOutput(string sourse)
        {
            var doc = new XmlDocument();
            doc.LoadXml(sourse);
            return Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
        }
    }
}
