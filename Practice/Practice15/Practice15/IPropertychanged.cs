using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{

    public delegate void PropertyeventHandler(object sender, PropertyeventArgs args);
    public interface IPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }
}
