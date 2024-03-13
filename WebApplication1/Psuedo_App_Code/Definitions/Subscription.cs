using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1 {
    public class Subscription {
        static List<Subscription> List { get; set; } = new List<Subscription>();
        public int ID { get; set; }
        public string Name { get; set; }
        public int Payment { get; set; }
        public int Duration { get; set; }
        public Subscription(int ID, string Name, int Payment, int Duration) {
            this.ID = ID;
            this.Name = Name;
            this.Payment = Payment;
            this.Duration = Duration;
            List.Add(this);
        }
    }
}