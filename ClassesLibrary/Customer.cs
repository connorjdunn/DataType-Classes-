using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //FIELDS - Automatic properties - no buisness rules

        //Properties
        public string StreetAdress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ContactInfo CustomerContactInfo { get; set; }

    }
}
