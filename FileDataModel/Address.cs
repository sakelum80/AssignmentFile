using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDataModel
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
    }
}
