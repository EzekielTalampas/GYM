using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1 {
    public class Transaction {
        static List<Transaction> List { get; set; } = new List<Transaction>();
        public string ID { get; set; }
        public int CustomerID { get; set; }
        public int SubscriptionID { get; set; }
        public string DateOfPurchase { get; set; }
        public Transaction(string ID, int CustomerID, int SubscriptionID, string DateOfPurchase) {
            this.ID = ID;
            this.CustomerID = CustomerID;
            this.SubscriptionID = SubscriptionID;
            this.DateOfPurchase = DateOfPurchase;
            List.Add(this);
        }
    }
}