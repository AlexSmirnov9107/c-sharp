using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    public class CustomObject : IPropertychanged
    {
        private int _count;
        private string _name;
        private int _myproperty;

        public int Count
        {
            get
            {
                return this._count;
            }
            set
            {
                Propertychanged?.Invoke(this, new PropertyeventArgs("Count", value));
                this._count = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name; ;
            }
            set
            {
                this._name = value;
                Propertychanged?.Invoke(this, new PropertyeventArgs("Name", value));
            }
        }
        public int MyProperty
        {
            get
            {
                return this._myproperty;
            }
            set
            {
                this._myproperty = value;
                Propertychanged?.Invoke(this, new PropertyeventArgs("MyProperty", value));
            }
        }

        public event PropertyeventHandler Propertychanged;
    }
}
