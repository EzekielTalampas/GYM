using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxFitnessGym.App_Code {
    public class SubscriptionData {
        static List<SubscriptionData> List { get; set; } = new List<SubscriptionData>();
        public int ID { get; set; }
        public string Name { get; set; }
        public int Payment { get; set; }
        public int Duration { get; set; }
        public SubscriptionData(int ID, string Name, int Payment, int Duration) {
            this.ID = ID;
            this.Name = Name;
            this.Payment = Payment;
            this.Duration = Duration;
            List.Add(this);
        }
    }
}