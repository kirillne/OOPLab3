using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomConverters
{
    internal static class CustomJsonToXmlConverter
    {
        private static int tabCount = 0;

        public static string Convert(string sourse)
        {
            tabCount = 0;
            String result = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n";
            var reader = new StringReader(sourse);

            String nextString = reader.ReadLine();
            while (nextString != null)
            {
                result += WriteElement(reader, nextString);
                nextString = reader.ReadLine();
            }
            
           return result;
        }

        private static string WriteElement(StringReader reader, string nextString)
        {
            var node = new Node(nextString);
            String result = String.Format("{0}<{1} ",new String(' ',tabCount), node.Name);
            if (node.Value == "[" || node.Value == "{")
            {
                result += WriteClass(reader, node.Name);
            }
            else
            {
                result += WriteValue(node.Value, node.Name);
            }
            return result;
        }

        private static string WriteValue(string value, string nodeName)
        {
            return String.IsNullOrEmpty(value) ? "/>\r\n" : String.Format(">{0}</{1}>\r\n", value, nodeName);
        }

        private static string WriteClass(StringReader reader, String nodeName)
        {
            String nextString = reader.ReadLine();
            String result = "";
            if (nextString == null) throw new ArgumentException("Invalid JSON");
            if (nextString.Trim().StartsWith("\"atributes\""))
            {
                result += ReadAtributes(reader);
                nextString = reader.ReadLine();
                if (nextString == null) throw new ArgumentException("Invalid JSON");
            }
            result += ">\r\n";
            tabCount++;
            while (nextString.Trim() != "]," && nextString.Trim() != "},")
            {
                result += WriteElement(reader,nextString);
                nextString = reader.ReadLine();
                if (nextString == null) throw new ArgumentException("Invalid JSON");
            }
            tabCount--;
            result += String.Format("{0}</{1}>\r\n", new String(' ',tabCount), nodeName);
            return result;

        }

        private static string ReadAtributes(StringReader reader)
        {
            String result = "";
            String nextString = reader.ReadLine();
            if(nextString == null) throw new ArgumentException("Invalid JSON");
            while (nextString.Trim() != "],")
            {
                var node = new Node(nextString);
                result += String.Format(" {0}=\"{1}\"", node.Name, node.Value);
                nextString = reader.ReadLine();
                if (nextString == null) throw new ArgumentException("Invalid JSON");
            }
            return result;
        }

        private class Node
        {
            public Node(String nodeString)
            {
                String[] stringParts = nodeString.Split( new string[] { "\" : " },StringSplitOptions.RemoveEmptyEntries);

                Name = stringParts[0].Trim().Trim(new char[] { '"' });
                Value = stringParts[1].Trim().Trim(new char[] { '"', ',' });
            }

            public String Name { get; set; }

            public String Value { get; set; }
        }
    }
}
