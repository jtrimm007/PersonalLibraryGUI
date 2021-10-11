using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Person : RegexLibraryHelper
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  StreetAddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Id { get; set; } // ETSU ID Number
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


    }
}
