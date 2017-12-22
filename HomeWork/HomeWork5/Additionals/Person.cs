using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additionals
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public static string GetInfo (Person p)
        {
            return (p.Name + " " + p.LastName);
        }
    }
}
