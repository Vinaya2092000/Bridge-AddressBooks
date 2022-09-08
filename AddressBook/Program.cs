namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Address Book");
            Console.WriteLine("Enter the details to create a contact");
            bool flag = true;
            int option;
            Address add = new Address();
            while (flag)
            {
                Console.WriteLine("Enter option: \n 1.Create \n 2.Add \n 3.Edit \n 4.Delete \n 5.Multiple \n 6.Mul-AddressBooks");
                Random random = new Random();
                option = random.Next(0, 4);
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.Create();
                        add.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter the number of contacts to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine("Enter the details to create contact");
                            add.Create();
                        }
                        Console.WriteLine("These contacts are stored");
                        add.Display();
                        break;
                    case 3:
                        Console.WriteLine("enter first name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("enter last name: ");
                        string lastName = Console.ReadLine();
                        add.Edit(firstName, lastName);
                        add.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the first name of the contact to delete the details ");
                        string firstName1 = Console.ReadLine();
                        Console.WriteLine("Enter the last name of the contact to delete the details ");
                        string lastName1 = Console.ReadLine();
                        add.Delete(firstName1, lastName1);
                        break;
                    case 5:
                        Console.WriteLine("1 : for adding contacts");
                        Console.WriteLine("2 : for editing a contact");
                        Console.WriteLine("3 : for deleting a contact");
                        Console.WriteLine("4 : for displaying the list stored");
                        Console.WriteLine("5 : exiting the program");
                        int choice = Convert.ToInt16(Console.ReadLine());
                        add.Choice(choice,add);
                        break;
                    case 6:
                        MultipleBooks multipleBooks = new MultipleBooks();
                        multipleBooks.Books();
                        break;
                }
            }
        }
    }
}