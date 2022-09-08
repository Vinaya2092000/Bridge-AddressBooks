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
                Console.WriteLine("Enter option: \n 1.Create \n 2.Add");
                Random random = new Random();
                option = random.Next(0, 2);
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
                }
            }
        }
    }
}