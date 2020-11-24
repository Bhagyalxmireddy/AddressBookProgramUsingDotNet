using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookDetails
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long phoneNumber;
        public long zip;
        List<ContactPerson> personDetails = new List<ContactPerson>();


        public void addPersonDetails()
        {
            Console.WriteLine("Enter person Details :");
            Console.WriteLine("\n Enter FirstName : ");
            firstName = Console.ReadLine();
            Console.WriteLine("\n Enter LastName : ");
            lastName = Console.ReadLine();
            Console.WriteLine("\n Enter Address : ");
            address = Console.ReadLine();
            Console.WriteLine("\n Enter City : ");
            city = Console.ReadLine();
            Console.WriteLine("\n Enter State : ");
            state = Console.ReadLine();
            Console.WriteLine("\n Enter MobileNumber : ");
            phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter Zip : ");
            zip = long.Parse(Console.ReadLine());

            personDetails.Add(new ContactPerson(firstName, lastName,address, city, state, phoneNumber, zip));
            foreach (ContactPerson addPerson in personDetails)
                Console.WriteLine(addPerson.toString());
            Console.WriteLine("Person Details  Added Successfully \n");
        }
    }
}
