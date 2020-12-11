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
            FileRead_Write filewr = new FileRead_Write();
            bool i = true;
            while (i)
            {
                Console.WriteLine("List of files present in AddressBook");
                filewr.ShowFiles();
                Console.WriteLine("Enter a fileName to operate");
                string fileName = Console.ReadLine();
                Console.WriteLine("1.AddPersonDetails From AddressBook ");
                Console.WriteLine("2.printPersonDetails From AddressBook ");
                Console.WriteLine("3.EditPersonDetails From AddressBook ");
                Console.WriteLine("4.DeletePersonDetails From AddressBook");
                Console.WriteLine("5.Search Person By city or state");
                Console.WriteLine("6.ViewPerson By City or State");
                Console.WriteLine("7.Count of ContactPersons BY city or state");
                Console.WriteLine("8.Sort the persons by firstname");
                Console.WriteLine("9.Sort the persons by City,State or Zip");
                Console.WriteLine("10.Exit ");
                try
                {
                    choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            addressBook.addPersonDetails(fileName);
                            break;
                        case 2:
                            addressBook.printPersonDetails(fileName);
                            break;
                        case 3:
                            addressBook.editPersonDetails(fileName);
                            break;
                        case 4:
                            addressBook.deletePerson(fileName);
                            break;
                        case 5:
                            addressBook.search_ByCity_State(fileName);
                            break;
                        case 6:
                            addressBook.View_ByState_City(fileName);
                            break;
                        case 7:
                            addressBook.CountPerson(fileName);
                            break;
                        case 8:
                            addressBook.sort_By_FirstName(fileName);
                            break;
                        case 9:
                            addressBook.sort_By_StateCity_Zip(fileName);
                            break;
                        case 10:
                            i = false;
                            break;
                        default:
                            Console.WriteLine("Choose proper option");
                            break;
                    }
                }catch(System.FormatException fe)
                {
                    Console.WriteLine(fe.Message);
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
