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

            personDetails.Add(new ContactPerson(firstName, lastName, address, city, state, phoneNumber, zip));
            foreach (ContactPerson addPerson in personDetails)
                Console.WriteLine(addPerson.toString());
            Console.WriteLine("Person Details  Added Successfully \n");
        }

        public void printPersonDetails()
        {
            if (personDetails == null)
            {
                Console.WriteLine("There are no contact to print");
            }
            else
            {
                foreach (ContactPerson addPerson in personDetails)
                    Console.WriteLine(addPerson.toString());
            }
        }
        public void editPersonDetails()
        {
            {
                if (personDetails == null)
                {
                    Console.WriteLine("There are no contacts to edit");
                }
                else
                {
                    String address, city, state;
                    long phoneNumber, zip;
                    int id;

                    foreach (ContactPerson contact in personDetails)
                    {
                        Console.WriteLine("ID: " + personDetails.IndexOf(contact) + ":" + contact.firstName);
                    }
                    Console.WriteLine("Enter ID of contact to Edit : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("the person is:" + id);
                    foreach (ContactPerson editperson in personDetails)
                    {
                        Console.WriteLine("please select the option to edit...\n \n 1. Address \n 2.city \n 3.state \n 4.zip \n 5.phone number");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Address: ");
                                 address = Console.ReadLine();
                                editperson.setAddress(address);
                                break;
                            case 2:
                                Console.WriteLine("Enter city: ");
                                 city = Console.ReadLine();
                                editperson.setCity(city);
                                break;
                            case 3:
                                Console.WriteLine("Enter state: ");
                                 state = Console.ReadLine();
                                editperson.setState(state);
                                break;
                            case 4:
                                Console.WriteLine("Enter Zip: ");
                                 zip = long.Parse(Console.ReadLine());
                                editperson.setZip(zip);
                                break;
                            case 5:
                                Console.WriteLine("Enter phonenumber: ");
                                 phoneNumber = long.Parse(Console.ReadLine());
                                editperson.setPhoneNumber(phoneNumber);
                                break;
                            default:
                                Console.WriteLine("enter a valid option");
                                break;
                        }
                    }
                    foreach (ContactPerson addPersonDetails in personDetails)
                    {
                        Console.WriteLine(addPersonDetails.toString());
                    }

                }


            }
        }
    }
}
