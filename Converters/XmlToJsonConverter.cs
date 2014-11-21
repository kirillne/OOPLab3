using System;
using System.IO;
using System.Xml;

namespace Converters
{
    public class XmlToJsonConverter
    {

        private int tabCount = 0;

        public string Convert(String xml)
        {
            tabCount = 0;
            String result = "";
            XmlReader reader = XmlReader.Create(new StringReader(xml));
            
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    result +=  WriteElement(reader);
                }
            }
            return result;
        }

        private string WriteAtributes(XmlReader reader)
        {
            String result = "";
            if (reader.HasAttributes)
            {
                result = string.Format("{0}\"atributes\" : [\r\n", new string('\t', tabCount));
                reader.MoveToFirstAttribute();
                tabCount++;
                for (int i = 0; i < reader.AttributeCount; i++)
                {
                    result += new string('\t', tabCount) +
                              String.Format("\"{0}\" : \"{1}\"\r\n", reader.Name, reader.Value);
                    reader.MoveToNextAttribute();
                }
                tabCount--;
                result += string.Format("{0}],\r\n", new string('\t', tabCount));
                reader.MoveToElement();
            }
            return result;
        }

        private string WriteClass(XmlReader reader, char openChar, char closeChar)
        {
            String result = string.Format("{0}\"{1}\":", new string('\t', tabCount), reader.Name);
            tabCount++;
            if (reader.IsEmptyElement)
            {
                return WriteEmptyValue(result);
            }
            if (!reader.HasAttributes)
            {
                reader.Read();
                if (reader.NodeType == XmlNodeType.Text )
                {
                    result += WriteText(reader);
                    tabCount--;
                    return result;
                }
                result += string.Format(" {0}\r\n", openChar);
            }
            else
            {
                result += string.Format(" {0}\r\n", openChar);
                result += WriteAtributes(reader);
                reader.Read();
            }

            do
            {
                result += WriteElement(reader);
            } while (reader.Read() && reader.NodeType != XmlNodeType.EndElement);
            result += string.Format("{0}{1},\r\n", new string('\t', tabCount), closeChar);

            tabCount--;
            return result;
        }

        private string WriteEmptyValue(string result)
        {
            result += "\"\"\r\n";
            tabCount--;
            return result;
        }


        private string WriteElement(XmlReader reader)
        {
            String result = "";
            if (reader.NodeType == XmlNodeType.Element)
            {
                if (reader.Name.StartsWith("Array"))
                {
                    result += WriteClass(reader, '[', ']');
                }
                else
                {
                    result += WriteClass(reader, '{', '}');
                }
            }
            return result;
        }

        private string WriteText(XmlReader reader)
        {
            String result = "";
            result += string.Format(" \"{0}\",\r\n",reader.Value);
            reader.Read();
            return result;
        }
    }
}
