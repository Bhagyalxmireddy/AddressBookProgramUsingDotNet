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
            while (choice1 < 5)
            {
                Console.WriteLine("1.AddPersonDetails From AddressBook ");
                Console.WriteLine("2.printPersonDetails From AddressBook ");
                Console.WriteLine("3.EditPersonDetails From AddressBook ");
                Console.WriteLine("4.DeletePersonDetails From AddressBook");
                Console.WriteLine("5.Exit ");
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
                    case 4:
                        addressBook.deletePerson();
                        break;
                    default:
                        Console.WriteLine("Choose proper option");
                        break;
                }
            }
        }
    }
}
