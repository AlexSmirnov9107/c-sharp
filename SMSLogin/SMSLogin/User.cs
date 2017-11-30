using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSLogin
{
    public class User : IEquatable<User>
    {
        private string name;
        private string password;
        private string phone;
        private string email;

        public User()
        {

        }

        public User(string name,string password,string phone,string email)
        {
            this.name = name;
            this.password = password;
            this.phone = phone;
            this.email = email;
        }
        public bool Equals(User other)
        {
            return (email == other.email) || (phone == other.phone);
        }
        public string GetName()
        {
            return name;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetPhone()
        {
            return phone;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetName(string n)
        {
            name = n;
        }
        public void SetPassword(string p)
        {
            password = p;
        }
        public void SetPhone(string ph)
        {
            phone = ph;
        }
        public void SetEmail(string e)
        {
            email = e;
        }

 
    }
}
