using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice1 = 0;
            Console.WriteLine("Welcome to Address Book Program ");
            AddressBookDetails addressBook = new AddressBookDetails();
            while (choice1 < 4)
            {
                Console.WriteLine("1.AddPersonDetails to AddressBook ");
                Console.WriteLine("2.printPersonDetails to AddressBook ");
                Console.WriteLine("3.EditPersonDetails to AddressBook ");
                Console.WriteLine("4.Exit ");
                choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        addressBook.addPersonDetails();
                        break;
                    case 2:
                        addressBook.printPersonDetails();
                        break;
                    case 3:
                        addressBook.editPersonDetails();
                        break;
                    default:
                        Console.WriteLine("Choose proper option");
                        break;
                }
            }
        }
    }
}
