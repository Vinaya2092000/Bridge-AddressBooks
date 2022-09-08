using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    /// The List<T> class defined in the System.Collections.Generic namespace is a generic class
    /// and can store any data types to create a list.
    public class Address
    {
        List<Contacts> add_book = new List<Contacts>();
        //created an address book list of contact class type
        public void Create()    //created an object of the contact class & add contact details
        {
            Contacts contact = new Contacts();
            Console.WriteLine("Enter your first name");
            contact.first_name = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            contact.last_name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter your city");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter your zip code");
            contact.zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            contact.phone_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            contact.email = Console.ReadLine();
            add_book.Add(contact);
        }
        public void Display()               //displaying details of each conatact
        {
            foreach (var data in add_book)
            {
                Console.WriteLine($"Contact No. - {data}");
                Console.WriteLine($"Name - {data.first_name} {data.last_name}");
                Console.WriteLine($"Address - {data.address}");
                Console.WriteLine($"City- {data.city}");
                Console.WriteLine($"State - {data.state}");
                Console.WriteLine($"Zip - {data.zip}");
                Console.WriteLine($"Phone no - {data.phone_no}");
                Console.WriteLine($"Email - {data.email}");
            }
        }
    }
}
