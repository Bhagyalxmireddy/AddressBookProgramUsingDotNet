using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
   public  class ContactPerson
    {
         public String firstName{ get; set; }
         public String lastName{ get; set; }
         public String address{ get; set; }
         public String city{ get; set; }
         public String state{ get; set; }
         public String phoneNumber { get; set; }
         public String zip { get; set; }
        public ContactPerson(String firstName, String lastName, String address, String city, String state, String phoneNumber, String zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNumber = phoneNumber;
            this.zip = zip;
        }
     
        public string toString()
        {
            return "Name: " + firstName + " " + lastName + ", Address: " + address + ", City: " + city + ", State: " + state + ", MobileNumber: " + phoneNumber + ", PinCode: " + zip;
        }
    }
}
