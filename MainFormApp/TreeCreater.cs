using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormApp
{
    static class TreeCreater
    {
        public static TreeNode GetTree(List<object> objects)
        {
            var result = new TreeNode("Root") {Tag = objects};
            foreach (var o in objects)
            {
                result.Nodes.Add(GetTreeElement(o));
            }
            return result;
        }

        private static TreeNode GetTreeElement(object element)
        {
            Type elementType = element.GetType();
            TreeNode result;
            if (!elementType.IsValueType && !(element is String))
            {
                result = new TreeNode(elementType.Name) {Tag = element};
                PropertyInfo[] properties = elementType.GetProperties();
                foreach (var property in properties)
                {
                    result.Nodes.Add(GetTreeElement(property.GetValue(element)));
                }
            }
            else
            {
                result = new TreeNode(element.ToString()) { Tag = element };
            }
            return result;
        }

    }
}
