using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class MultipleBooks
    {
        public void Books()
        {
            Console.WriteLine("Enter 1 : To add an Addressbook\n 2 : To open an existing addressbook\n 3 : To print all\n  4 : to exit");
            int book = Convert.ToInt16(Console.ReadLine());
            NameBook add_book = new NameBook();
            do
            {
                if (book == 1)
                {
                    Console.WriteLine("Enter the new address book name");
                    string Book_name = Console.ReadLine();
                    add_book.Details(Book_name);
                }
                if (book == 2)
                {
                    Console.WriteLine("Enter the existing address book name");
                    string Book_name = Console.ReadLine();
                    if (add_book.search(Book_name))
                    {
                        add_book.addNames(Book_name);
                    }
                    else
                    {
                        Console.WriteLine("Address book not present");
                    }
                }
                if (book == 3)
                {
                    add_book.printAll();
                }
                Console.WriteLine("Enter 1 - To add an Addressbook\n      2 - To open an existing addressbook\n      3 - To print all\n      4 - to exit");
                book = Convert.ToInt16(Console.ReadLine());
            } while (book > 0 && book < 4);
        }
    }
}
