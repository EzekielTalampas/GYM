using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

namespace Pseudo_App_Code {
    public class CustomerData {
        public static string Temp = Environment.CurrentDirectory;
        static List<CustomerData> List { get; set; } = new List<CustomerData>();
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long PhoneNumber { get; set; }
        public CustomerData(int ID, string LastName, string FirstName, long PhoneNumber) {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.PhoneNumber = PhoneNumber;
            List.Add(this);
        }
        public static void Fetch() {
            /*
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Environment.CurrentDirectory}\App_Data\Database.mdf"";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString)) using (SqlCommand command = connection.CreateCommand()) {
                connection.Open();                                                                  //Open Connection
                command.CommandText = "SELECT * FROM Posts ORDER BY postedOn DESC";                 //Command
                List = command.ExecuteReader().Cast<IDataRecord>().Select(row => new CustomerData(  //Read Data and cast
                    (int)       row["ID"],
                    (string)    row["LastName"],
                    (string)    row["FirstName"],
                    (long)      row["PhoneNumber"]
                )).ToList();                                                                        //Convert to List<CustomerData>
                connection.Close();                                                                 //Close Connection
            }
            */
        }
    }
}