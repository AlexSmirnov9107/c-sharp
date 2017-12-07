using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Sensor : DeviceModel
    {
        object Data;

        public object GetData()
        {

            object dataForRead;
            if (!ReadData(out dataForRead))
            {
                throw new Exception("Не удалось получить данные с устройства");
            }
            this.Data = dataForRead;
            return this.Data;
        }
    }
}
