using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace AddressBook_IO
{
    public class Address_Book_Model
    {
        public string F_name;
        public string L_name;
        public string City;
        public string State;
        public string Zip;
        public string Phone;
        public string Email;
        public Address_Book_Model(string f_name, string l_name, string city, string state, string zip, string phone, string email)
        {
            F_name = f_name;
            L_name = l_name;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }
    }
}
     