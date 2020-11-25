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
        public String getFirstName()
        {
            return firstName;
        }
        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String getAddress()
        {
            return address;
        }
        public void setAddress(String address)
        {
            this.address = address;
        }
        public String getCity()
        {
            return city;
        }
        public void setCity(String city)
        {
            this.city = city;
        }
        public String getState()
        {
            return state;
        }
        public void setState(String state)
        {
            this.state = state;
        }
        public long getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setPhoneNumber(long phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public long getZip()
        {
            return zip;
        }
        public void setZip(long zip)
        {
            this.zip = zip;
        }
        
        public string toString()
        {
            return "Name: " + firstName + " " + lastName + "\t Address: " + address + "\t City: " + city + "\t State: " + state + "\t MobileNumber: " + phoneNumber + "\t PinCode: " + zip;
        }
    }
}
