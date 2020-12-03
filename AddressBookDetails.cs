﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        String NAME = "^[A-Z a-z]{3,}$";
        String PHONENUMBER = "^[1-9]{1}[0-9]{9}$";
        String ZIP = "^[1-9]{1}[0-9]{5}$";

        NLog nLog = new NLog();

        List<ContactPerson> personDetails = new List<ContactPerson>();
        Dictionary<String, List<ContactPerson>> personDictionary = new Dictionary<String, List<ContactPerson>>();
        Dictionary<String, String> cityDictionary = new Dictionary<string, string>();
        Dictionary<String, String> stateDictionary = new Dictionary<string, string>();

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
            try {
                    Console.WriteLine("Enter person Details :");
                    Console.WriteLine("\n Enter FirstName : ");
                    firstName = Console.ReadLine();
                     if (personDictionary.ContainsKey(firstName))
                    {
                        Console.WriteLine("Person already exist,enter different Name");
                    }
                    else
                    {
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
                        validatingPersonDetails(firstName, lastName, phoneNumber, zip);

                        //   personDetails.Add(new ContactPerson(firstName, lastName, address, city, state, phoneNumber, zip));
                        foreach (ContactPerson addPerson in personDetails)
                            Console.WriteLine(addPerson.toString());
                        personDictionary.Add(firstName, personDetails);
                        // Console.WriteLine("Person Details  Added Successfully \n");
                    }
            }
            catch (AddressBookCustomException e)
            {
                throw new AddressBookCustomException(e.Message);
            }
            nLog.logDebug(" addPersondetails Debug succsufully");
        }

        public void printPersonDetails()
        {
            if (personDetails.Count == 0)
            {
                Console.WriteLine("There are no contact to print");
            }
            else
            {
                foreach (ContactPerson addPerson in personDetails)
                    Console.WriteLine(addPerson.toString());       
            }
            nLog.logDebug("PrintPersonDetails Debug succesfully");
        }
        public void editPersonDetails()
        {
            {
                if (personDetails.Count == 0)
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
                    nLog.logDebug("EditPersonDetails Debug succesfully");

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
                    nLog.logDebug("DeletePersonDetails Debug succesfully");
                }
                else
                {
                    Console.WriteLine("Enter a valid Name");
                }
            }
        }
        public void View_ByState_City()
        {
            Console.WriteLine("Choose how you want to view by city or state\n" + "1. city\n" + "2. state");
            try
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter city name to view person");
                        string viewCity = Console.ReadLine();
                        var searchCity = cityDictionary.Where(c => c.Value.Equals(viewCity));
                        foreach (var result in searchCity)
                            Console.WriteLine("Firstname:{0} , City:{1}", result.Key, result.Value);
                        break;
                    case 2:
                        Console.WriteLine("Enter state name to view person");
                        string viewState = Console.ReadLine();
                        var searchState = stateDictionary.Where(s => s.Value.Equals(viewState));
                        foreach (var result in searchState)
                            Console.WriteLine("Firstname:{0} , State:{1}", result.Key, result.Value);
                        break;
                }
            }
            catch (System.FormatException)
            {
                throw new AddressBookCustomException("Please enter correct input");
            }
        }
    }
}
