using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ItemType Type { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
