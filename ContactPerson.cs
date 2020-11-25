﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class ContactPerson
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
      /*  public String getFirstName()
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
     /*   public String getAddress()
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
        }*/
        
        public string toString()
        {
            return "Name: " + firstName + " " + lastName + "\t Address: " + address + "\t City: " + city + "\t State: " + state + "\t MobileNumber: " + phoneNumber + "\t PinCode: " + zip;
        }
    }
}
