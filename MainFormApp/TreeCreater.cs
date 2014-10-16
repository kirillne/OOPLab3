using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transports;

namespace MainFormApp
{
    static class TreeCreater
    {
        public static TreeNode GetTree(List<Transport> objects)
        {
            var result = new TreeNode("Root") { Tag = objects };
            foreach (var o in objects)
            {
                result.Nodes.Add(GetTreeElementByObject(o));
            }
            return result;
        }

        private static TreeNode GetTreeElementByObject(object element)
        {
            Type elementType = element.GetType();
            TreeNode result;
            result = new TreeNode(elementType.Name)
            {
                Tag =
                    new TreeNodeTag {ElementType = elementType, Value = element}
            };
            PropertyInfo[] properties = elementType.GetProperties();
            foreach (var property in properties)
            {
                result.Nodes.Add(GetTreeElementByProperty(property.GetValue(element),property));
            }

            return result;
        }

        private static TreeNode GetTreeElementByProperty(object element, PropertyInfo elementProperty)
        {
            Type elementType = element.GetType();
            TreeNode result;
            if (!elementType.IsValueType && !(element is String))
            {
                result = new TreeNode(elementProperty.Name);
                PropertyInfo[] properties = elementType.GetProperties();
                foreach (var property in properties)
                {
                    result.Nodes.Add(GetTreeElementByProperty(property.GetValue(element),property));
                }
            }
            else
            {
                result = new TreeNode(elementProperty.Name + ":" + element.ToString()) ;
            }
            result.Tag = new TreeNodeTag
            {
                ElementType = elementType,
                Value = element,
                PropertyInfo = elementProperty
            };
            
            return result;
        }

    }
}
