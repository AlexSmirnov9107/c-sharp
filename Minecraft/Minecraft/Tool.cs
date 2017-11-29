using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Tool : IEquatable<Tool>
    {
        
        public Material[] map = new Material[9];
        public string name;
        public Tool(Material[] reciept,string name)
        {
            this.map = reciept;
            this.name = name;
        }
        public bool Equals(Tool other)
        {
            int countEqual = 0;
            for (int i = 0; i < 9; i++)
            {
                if (map[i] == other.map[i] )
                {
                    countEqual++;
                }
            }
            if (countEqual == 9)
            {
                other.name = name;
                return true;
            }
            return false;
        }
        public static bool operator ==(Tool tool,List<Tool> tools)
        { 
            return (tools.Contains(tool));
        }
        public static bool operator !=(Tool tool, List<Tool> tools)
        {

            return !(tools.Contains(tool));
        }

    }
}
