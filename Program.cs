using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            AddressBookDetails addressBook = new AddressBookDetails();
            addressBook.addPersonDetails();
            Console.ReadKey();
        }
    }
}
