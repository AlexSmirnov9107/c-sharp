using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class DeviceModel : IDeviceContract
    {
        public string Port { get ; set; }
        public string Name { get ; set; }
        public bool IsConnected { get; set; }

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public bool Disconnect()
        {
            throw new NotImplementedException();
        }

        public bool ReadData(out object data)
        {
            throw new NotImplementedException();
        }

        public bool WriteData(object data)
        {
            throw new NotImplementedException();
        }
    }
}
