using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;


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
        List<int> personIndex = new List<int>();

        public void validatingPersonDetails(String firstName, String lastName, String phoneNumber, String zip)
        {
            if (Regex.IsMatch(firstName, NAME) && (Regex.IsMatch(lastName, NAME)) && (Regex.IsMatch(phoneNumber, PHONENUMBER)) && (Regex.IsMatch(zip, ZIP)))
            {
                personDetails.Add(new ContactPerson(firstName, lastName, address, city, state, phoneNumber, zip));
                personDictionary.Add(firstName, personDetails);
                cityDictionary.Add(firstName,  city);
                stateDictionary.Add(firstName, state);
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

                    //personDetails.Add(new ContactPerson(firstName, lastName, address, city, state, phoneNumber, zip));
                    foreach (ContactPerson addPerson in personDetails)
                        Console.WriteLine(addPerson.toString());
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
                    
                    Console.WriteLine("Enter FirstName to edit ");
                    String value = Console.ReadLine();
                    foreach (ContactPerson editPerson in personDetails)
                    {
                        if (value.Equals(editPerson.firstName))
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
                            printPersonDetails();
                        }
                    }
                    nLog.logDebug("EditPersonDetails Debug succesfully");

                }
            }

        }
        public void deletePerson()
        {
            Console.WriteLine("Enter FirstName to delete: ");
            String firstName = Console.ReadLine();

            for (int index = 0; index < personDetails.Count; index++)
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
       
            public void search_ByCity_State()
            {
                if (personDictionary.Count == 0)
                {
                    Console.WriteLine("There are no contacts to search");
                }
                else
                {
                    int choice;
                    Console.WriteLine("\n\t 1.Search By City :" + "\n\t 2.Search By State : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter city : ");
                            string cityName = Console.ReadLine();
                            foreach (ContactPerson person in personDetails.FindAll(c => c.city.Equals(cityName)).ToList())
                                Console.WriteLine(person.toString());
                            nLog.logDebug("Search ByCity Debug succesfully");
                            break;
                        case 2:
                            Console.WriteLine("Enter state : ");
                            string stateName = Console.ReadLine();
                            foreach (ContactPerson person in personDetails.FindAll(s => s.state.Equals(stateName)).ToList())
                                Console.WriteLine(person.toString());
                            nLog.logDebug("Search ByState Debug succesfully");
                            break;
                    }
                }
            }
        public void View_ByState_City()
        {
            Console.WriteLine(" Enter a option to view by city or state\n" + "1. city\n" + "2. state");
            try
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter city name to view person");
                        string viewCity = Console.ReadLine();
                        var cityName = cityDictionary.Where(c => c.Value.Equals(viewCity));
                        foreach (var result in cityName)
                            Console.WriteLine("Firstname:{0} , City:{1}", result.Key, result.Value);
                        break;
                    case 2:
                        Console.WriteLine("Enter state name to view person");
                        string viewState = Console.ReadLine();
                        var stateName = stateDictionary.Where(s => s.Value.Equals(viewState));
                        foreach (var result in stateName)
                            Console.WriteLine("Firstname:{0} , State:{1}", result.Key, result.Value);
                        break;
                }
            }
            catch (System.FormatException)
            {
                throw new AddressBookCustomException("Please enter correct input");
            }
        }
        public void CountPerson()
        {
            Console.WriteLine("Choose how you want to count by city or state\n" + "Press 1 for city\n" + "Press 2 for state");
            try
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter city name to search");
                        string countCity = Console.ReadLine();
                        int countByCity = personDetails.FindAll(s => s.city.Equals(countCity)).Count;
                        Console.WriteLine("No of persons present in addressbook for " + countCity + " is::" + countByCity);
                        break;
                    case 2:
                        Console.WriteLine("Enter state name to search");
                        string countState = Console.ReadLine();
                        int countByState = personDetails.FindAll(s => s.state.Equals(countState)).Count;
                        Console.WriteLine("No of persons present in addressbook for " + countState + " is::" + countByState);
                        break;
                }
            }
            catch (System.FormatException)
            {
                throw new AddressBookCustomException("Please enter correct input");
            }
        }
        public void sort_By_FirstName()
        {
           var name = personDetails.OrderBy(name => name.firstName);
            foreach (var sort in name)
                Console.WriteLine(sort.toString());
        }
    }
}
