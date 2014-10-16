using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SomeSerialiserLib
{
    public class SomeSerialiser 
    {
        public object Deserialize(Stream serializationStream)
        {
            throw new NotImplementedException();
        }

       

        public void Serialize(StreamWriter serializationStream,
            object graph)
        {
             Type graphType = graph.GetType();
            if (!graphType.IsSerializable) throw new SerializationException("Type " + graphType.FullName + " is not serialisable.");
            
            serializationStream.WriteLine(graphType.FullName);
            if (graphType.IsPrimitive || graph is String)
            {
                serializationStream.WriteLine(graph.ToString());
            }
            else if (graphType.GetInterfaces().Contains(typeof (IEnumerable)))
            {
                SerializeCollection(serializationStream, graph);
            }
            else
            {
                SerialiseComplexType(serializationStream, graph, graphType);
            }
        }

        private void SerialiseComplexType(StreamWriter serializationStream, object graph,
            Type graphType)
        {
            PropertyInfo[] propertyInfos = graphType.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                if (!propertyInfo.CanRead ||
                    Attribute.IsDefined(propertyInfo, typeof (NonSerializedAttribute)))
                {
                    continue;
                }
                serializationStream.WriteLine(propertyInfo.Name);
                Serialize(serializationStream, propertyInfo.GetValue(graph));
            }
        }

        private void SerializeCollection(StreamWriter serializationStream, object graph)
        {
            var enumerable = (IEnumerable) graph;
            foreach (object element in enumerable)
            {
                Serialize(serializationStream, element);
            }
        }

        public ISurrogateSelector SurrogateSelector { get; set; }
        public SerializationBinder Binder { get; set; }
        public StreamingContext Context { get; set; }
    }
}
