using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Room : IRoomContract
    {
        public string Name { get; set; }
        public List<Controller> Controls { get; set; }
        public List<Sensor> Sensors { get ; set ; }
        public Room()
        {
            Controls = new List<Controller>();
            Sensors = new List<Sensor>();
        }
        public Sensor GetSensorByName(string value)
        {
            return this.Sensors.Single(x => x.Name == value);
        }
        public void AddSensor(string name,string port)
        {
            this.Sensors.Add(new Sensor { Name = name, Port = port });
        }

    }
}
