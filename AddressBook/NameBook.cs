using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class NameBook
    {
        Dictionary<string, Address> Address;
        Address add = new Address();
        public NameBook()
        {
            Address = new Dictionary<string, Address>();
        }

        public void Details(String name)
        {
            Address[name] = add;
            add.Choice(1, add);
            //Address.Add(name,obj1);
        }
        public bool search(string find)
        {
            int flag = 0;

            foreach (var i in Address)        //i represents the dictionary
            {
                if (i.Equals(find))
                {
                    add.Choice(1, i.Value);
                    flag++;
                    break;
                }
            }
            if (flag == 0)
            {
                return false;
            }
            return true;
        }
        public void addNames(String name)
        {

            Address[name].Create();
            add.Choice(1, Address[name]);
        }

        public void printAll()
        {
            foreach (var i in Address)
            {
                Console.WriteLine("Address name - " + i);
                i.Value.Display();
            }
        }
    }
}
