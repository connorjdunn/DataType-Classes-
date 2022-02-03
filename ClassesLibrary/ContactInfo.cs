﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        private string _streetAdress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAdress
        {
            get { return _streetAdress; }
            set { _streetAdress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public ContactInfo(string streetAdress, string city, string state, string zip, string phone, string email)
        {
            StreetAdress = streetAdress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public ContactInfo()
        {

        }

        public override string ToString()
        {
            return string.Format("Street Adress: {0}\n" +
                "City: {1}\n" +
                "State: {2}\n" +
                "Zip: {3}\n" +
                "Phone: {4}\n" +
                "Email: {5}\n", StreetAdress, City, State, Zip, Phone, Email);
        }
    }
}
