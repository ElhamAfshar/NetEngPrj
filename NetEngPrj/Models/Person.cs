using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetEngPrj.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string  firstname { get; set; }
        public string Lastname { get; set; }
        public string Ssn { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Married { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

    }
}