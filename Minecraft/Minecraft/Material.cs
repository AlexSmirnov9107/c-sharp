using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Material
    {
        public int type;
        public string name;
        public Material(int type,string name)
        {
            this.name = name;
            this.type = type;
        }
        public void SetType(int type)
        {
            this.type = type;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetTypeId()
        {
            return this.type;
        }
        public override string ToString()
        {
            return (type == -1 ? " " : type.ToString());
        }
       
    }
}
