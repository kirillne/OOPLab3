using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AssemblyLoader;

namespace SomeSerialiserLib
{
    public class SomeSerialiser 
    {
        public object Deserialize(StreamReader serializationStream)
        {

            Loader.Load("Libs");
            String assemblyString = serializationStream.ReadLine();
            String typeString = serializationStream.ReadLine();
            if (typeString == null || assemblyString == null) throw new SerializationException("Uncorrect serializationStream");
            Type graphType = Binder.BindToType(assemblyString, typeString);
            if (graphType == null) throw new SerializationException("Unknown type " + typeString);

            if (graphType.IsPrimitive || graphType.Equals(typeof(String)))
            {
                return DeserializePrimitiveAndStrings(serializationStream, graphType);
            }
            if (graphType.GetInterfaces().Contains(typeof (IList)))
            {
                return DeserialiseCollection(serializationStream, graphType);
            }
            return DeserialiseComplexObject(serializationStream, graphType, typeString);
        }

        private object DeserialiseComplexObject(StreamReader serializationStream,
            Type graphType, string typeString)
        {
            object graph = Activator.CreateInstance(graphType);
            while (serializationStream.Peek() != '[')
            {
                String propertyName = serializationStream.ReadLine();
                if (propertyName == null)
                    throw new SerializationException("Uncorrect serializationStream");
                PropertyInfo propertyInfo = graphType.GetProperty(propertyName);
                if (propertyInfo == null)
                    throw new SerializationException("Unknown prorepty " + propertyName +
                                                     " in " + typeString);
                if (!propertyInfo.CanWrite)
                    throw new SerializationException("Can't change value of " +
                                                     propertyName + " in " + typeString);
                propertyInfo.SetValue(graph, Deserialize(serializationStream));
            }
            serializationStream.ReadLine();
            return graph;
        }

        private object DeserialiseCollection(StreamReader serializationStream,
            Type graphType)
        {
            var list = (IList)Activator.CreateInstance(graphType);
            while (serializationStream.Peek() != '{')
            {
                list.Add(Deserialize(serializationStream));
            }
            return list;
        }

        private static object DeserializePrimitiveAndStrings(
            StreamReader serializationStream, Type graphType)
        {
            String valueString = serializationStream.ReadLine();
            var converter = TypeDescriptor.GetConverter(graphType);
            return converter.ConvertFrom(valueString);
        }


        public void Serialize(StreamWriter serializationStream,
            object graph)
        {
             Type graphType = graph.GetType();
            if (!graphType.IsSerializable) throw new SerializationException("Type " + graphType.FullName + " is not serialisable.");
            String assemblyString = "";
            String typeString = "";
            Binder.BindToName(graphType,out assemblyString, out typeString);
            serializationStream.WriteLine(assemblyString);
            serializationStream.WriteLine(typeString);
            if (graphType.IsPrimitive || graph is String)
            {
                serializationStream.WriteLine(graph.ToString());
            }
            else if (graphType.GetInterfaces().Contains(typeof(IList)))
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
            serializationStream.WriteLine("[=End Complex Type=]");
        }

        private void SerializeCollection(StreamWriter serializationStream, object graph)
        {
            var enumerable = (IList)graph;
            foreach (object element in enumerable)
            {
                Serialize(serializationStream, element);
            }
            serializationStream.WriteLine("{=End Collection=}");
        }

        public ISurrogateSelector SurrogateSelector { get; set; }
        public SerializationBinder Binder { get; set; }
        public StreamingContext Context { get; set; }
    }
}
