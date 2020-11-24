using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class ContactPerson
    {
        public ContactPerson(String firstName, String lastName, String address, String city, String state, long phoneNumber, long zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNumber = phoneNumber;
            this.zip = zip;
        }
        public String firstName
        {
            get;
            set;
        }
        public String lastName { get; set; }
        public String address { get; set; }
        public String city { get; set;}
        public String state { get; set; }
        public long phoneNumber { get; set; }
        public long zip { get; set; }

        public string toString()
        {
            return "Name:" + firstName + " " + lastName + "\t Address:" + address + "\t City:" + city + "\t State:" + state + "\t MobileNumber" + phoneNumber + "\t PinCode" + zip;
        }
    }
}
