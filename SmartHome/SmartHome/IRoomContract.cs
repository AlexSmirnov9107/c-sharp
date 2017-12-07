using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IRoomContract
    {
        string Name { get; set; }
        List<Controller> Controls { get; set; }
        List<Sensor> Sensors { get; set; }



    }
}
