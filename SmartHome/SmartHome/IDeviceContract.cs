using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IDeviceContract
    {
        string Port { get; set; }
        string Name { get; set; }

        bool IsConnected { get; set; }
        bool Connect();
        bool Disconnect();

        bool ReadData(out object data);
        bool WriteData(object data);
    }
}
