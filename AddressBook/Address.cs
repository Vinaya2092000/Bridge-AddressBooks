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
        //created an address book list of contact class type
        List<Contacts> add_book = new List<Contacts>();
        public Contacts person { get; private set; }
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
        public void Edit(String Fname, String Lname)    //edit details of existing contact
        {
            Contacts contact = new Contacts();
            //foreach loop is a control flow statement for iterate items in a collection
            foreach (var person in add_book)
            {
                if (person.first_name.Equals(Fname) && person.last_name.Equals(Lname))  //Comparison
                {
                    this.person = person;

                    Console.WriteLine("Enter an option to update\n 1.Firstname \n 2.Lastname \n 3.Address \n 4.City \n 5.State \n 6.Zip \n 7.PhoneNo \n 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter your first name");
                            person.first_name = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter your last name");
                            person.last_name = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter your address");
                            person.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter your city");
                            person.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter your state");
                            person.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter your zip code");
                            person.zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter your phone number");
                            person.phone_no = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter your email");
                            person.email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Enter the Valid option");
                            break;
                    }
                }
            }
            Display();
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
