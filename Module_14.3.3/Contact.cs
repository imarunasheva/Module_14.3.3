using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_14._3._3
{
    public class Contact(string name, string lastName, long phoneNumber, String email)
    {
        public String Name { get; } = name;
        public String LastName { get; } = lastName;
        public long PhoneNumber { get; } = phoneNumber;
        public String Email { get; } = email;
    }
}
