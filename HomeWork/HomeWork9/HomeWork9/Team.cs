using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Team
    {
        public List<Worker> Workers { get; set; }
        public TeamLeader TeamLeader { get; set; }
        public Team()
        {
            Workers = new List<Worker>();
        }
    }
}
