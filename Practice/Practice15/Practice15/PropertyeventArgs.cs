using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    public class PropertyeventArgs
    {
        public string name;
        public object value;
        public PropertyeventArgs(string name,object value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
