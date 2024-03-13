using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pseudo_App_Code {
    public class TransactionData {
        static List<TransactionData> List { get; set; } = new List<TransactionData>();
        public string ID { get; set; }
        public int CustomerID { get; set; }
        public int SubscriptionID { get; set; }
        public string DateOfPurchase { get; set; }
        public TransactionData(string ID, int CustomerID, int SubscriptionID, string DateOfPurchase) {
            this.ID = ID;
            this.CustomerID = CustomerID;
            this.SubscriptionID = SubscriptionID;
            this.DateOfPurchase = DateOfPurchase;
            List.Add(this);
        }
    }
}