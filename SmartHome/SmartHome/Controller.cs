using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Controller:DeviceModel
    {
        int CurrentValue { get; set; }
        void SetValue(int value)
        {
            
            if (!WriteData(value))
            {
                throw new Exception("Не удалось установить значение устройству");
            }
            CurrentValue = value;
        }
        public void IncreaseValue(int value = 1)
        {    
            SetValue(CurrentValue + value);
        }
        public void DecreaseValue(int value = 1)
        {
            SetValue(CurrentValue - value);
        }
        public int GetValue()
        {
            object dataForRead;
            if (!ReadData(out dataForRead))
            {
                throw new Exception("Не удалось получить данные с устройства");
            }
            CurrentValue = Convert.ToInt32(dataForRead);
            return CurrentValue;
        }
    }
}
