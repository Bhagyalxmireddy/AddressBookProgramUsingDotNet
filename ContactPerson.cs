using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class ContactPerson
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long phoneNumber;
        public long zip;

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
    }
}
