using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    public class InputLocalization : System.Attribute
    {
        public string Name { get; set; }
        public InputLocalization()
        { }

        public InputLocalization(string name)
        {
            Name = name;
        }
    }
}
