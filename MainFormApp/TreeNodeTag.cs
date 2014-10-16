using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainFormApp
{
    public class TreeNodeTag
    {
        public Type ElementType { get; set; }

        public Object Value { get; set; }

        public PropertyInfo PropertyInfo { get; set; }
    }
}
