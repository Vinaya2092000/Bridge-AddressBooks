using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contacts
    {
        // get method returns the value of the variable name .
        // set method assigns a value to the name variable .
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public long zip { get; set; }
        public long phone_no { get; set; }
        public String email { get; set; }
    }
}
