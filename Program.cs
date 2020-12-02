using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice1;
            Console.WriteLine("Welcome to Address Book Program ");
            AddressBookDetails addressBook = new AddressBookDetails();
            bool i = true;
            while (i)
            {
                Console.WriteLine("1.AddPersonDetails From AddressBook ");
                Console.WriteLine("2.printPersonDetails From AddressBook ");
                Console.WriteLine("3.EditPersonDetails From AddressBook ");
                Console.WriteLine("4.DeletePersonDetails From AddressBook");
                Console.WriteLine("5.Search Person By city or state");
                Console.WriteLine("6.Exit ");
                try
                {
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
                        case 5:
                            addressBook.search_ByCity_State();
                            break;
                        case 6:
                            i = false;
                            break;
                        default:
                            Console.WriteLine("Choose proper option");
                            break;
                    }
                }
                catch(AddressBookCustomException ex)
                {
                    throw new AddressBookCustomException(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
