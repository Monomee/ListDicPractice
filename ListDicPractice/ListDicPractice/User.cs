using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDicPractice
{
    public class User
    {
        private string name;
        private string phoneNumber;
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public User()
        {
        }

        public User(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\t" + "PhoneNumber:" + PhoneNumber;
        }

    }
}
