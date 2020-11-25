using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook
{
    class AddressBookDetails
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public String phoneNumber;
        public String zip;
        String NAME = "^[a-z]{3,}$";
        String PHONENUMBER = "^[1-9]{1}[0-9]{9}$";
        String ZIP = "^[1-9]{1}[0-9]{5}$";


        List<ContactPerson> personDetails = new List<ContactPerson>();


        public void validatingPersonDetails(String firstName,String lastName, String phoneNumber,String zip)
        {
            if(Regex.IsMatch(firstName, NAME) && (Regex.IsMatch(lastName, NAME)) && (Regex.IsMatch(phoneNumber, PHONENUMBER)) && (Regex.IsMatch(zip, ZIP)))
            {
                personDetails.Add(new ContactPerson(firstName, lastName, address, city, state, phoneNumber, zip));
            }
            else
            {
                Console.WriteLine("Enter a valid details");
            }
        }


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
            phoneNumber = Console.ReadLine();
            Console.WriteLine("\n Enter Zip : ");
            zip = Console.ReadLine();
            validatingPersonDetails(firstName,lastName,phoneNumber,zip);
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
                    String phoneNumber, zip;
                    int id;

                    foreach (ContactPerson contact in personDetails)
                    {
                        Console.WriteLine("ID: " + personDetails.IndexOf(contact) + ":" + contact.firstName);
                    }
                    Console.WriteLine("Enter ID of contact to Edit : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("the person is:" + id);
                    foreach (ContactPerson editPerson in personDetails)
                    {
                        Console.WriteLine("please select the option to edit...\n \n 1. Address \n 2.city \n 3.state \n 4.zip \n 5.phone number");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Address: ");
                                 address = Console.ReadLine();
                                 editPerson.address = address;
                                break;
                            case 2:
                                Console.WriteLine("Enter city: ");
                                 city = Console.ReadLine();
                                editPerson.city = city;
                                break;
                            case 3:
                                Console.WriteLine("Enter state: ");
                                state = Console.ReadLine();
                                editPerson.state = state;
                                break;
                            case 4:
                                Console.WriteLine("Enter Zip: ");
                                zip = Console.ReadLine();
                                editPerson.zip = zip;
                                break;
                            case 5:
                                Console.WriteLine("Enter phonenumber: ");
                                phoneNumber = Console.ReadLine();
                                editPerson.phoneNumber = phoneNumber;
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
        public void deletePerson()
        {
            Console.WriteLine("Enter FirstName to delete: ");
            String firstName = Console.ReadLine();

            for(int index = 0; index < personDetails.Count; index++)
            {
                if (personDetails[index].firstName.Equals(firstName))
                {
                    personDetails.RemoveAt(index);
                    Console.WriteLine("Contact deleted");
                }
                else
                {
                    Console.WriteLine("Enter a valid Name");
                }
            }
        }
    }
}
