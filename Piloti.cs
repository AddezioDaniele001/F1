using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models
{
    public class Piloti
    {
        public class Driver
        {
            public string driverId { get; set; }
            public string url { get; set; }
            public string givenName { get; set; }
            public string familyName { get; set; }
            public string dateOfBirth { get; set; }
            public string nationality { get; set; }
            public string permanentNumber { get; set; }
            public string code { get; set; }
        }

        public class DriverTable
        {
            public string season { get; set; }
            public List<Driver> Drivers { get; set; }
        }

        public class MRData
        {
            public string xmlns { get; set; }
            public string series { get; set; }
            public string url { get; set; }
            public string limit { get; set; }
            public string offset { get; set; }
            public string total { get; set; }
            public DriverTable DriverTable { get; set; }
        }

        public class Root
        {
            public MRData MRData { get; set; }
        }


    }
}
