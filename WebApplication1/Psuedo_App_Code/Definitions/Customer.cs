using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1 {
    public class Customer {
        static List<Customer> List { get; set; } = new List<Customer>();
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long PhoneNumber { get; set; }
        public Customer(int ID, string LastName, string FirstName, long PhoneNumber) {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.PhoneNumber = PhoneNumber;
            List.Add(this);
        }
    }
}