using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaxFitnessGym
{
    using System;
    using System.Data.SqlClient;

    public partial class NewClient : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Define connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\John Paulo A. Buan\Documents\GitHub\GYM\MaxFitnessGym\App_Data\GymDB.mdf"";Integrated Security=True";

            // SQL queries to insert data into the tables
            string customerQuery = "INSERT INTO Customer (LastName, FirstName, PhoneNumber) " +
                                   "VALUES (@LastName, @FirstName, @PhoneNumber); SELECT SCOPE_IDENTITY();";

            string subscriptionQuery = "INSERT INTO Subscription (CustomerID, SubscriptionName, Payment, Duration) " +
                                       "VALUES (@CustomerID, @SubscriptionName, @Payment, @Duration); SELECT SCOPE_IDENTITY();";

            string transactionQuery = "INSERT INTO Transactions (CustomerID, SubscriptionID, DateofPurchase) " +
                                      "VALUES (@CustomerID, @SubscriptionID, @DateofPurchase)";

            // Create connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Start a transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert into Customer table
                    int customerId;
                    using (SqlCommand command = new SqlCommand(customerQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                        customerId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    // Map selected subscription duration
                    int duration;
                    switch (ddlMembershipType.SelectedValue)
                    {
                        case "Session":
                            duration = 1;
                            break;
                        case "Weekly":
                            duration = 7;
                            break;
                        case "Bi-Weekly":
                            duration = 14;
                            break;
                        case "Monthly":
                            duration = 30;
                            break;
                        default:
                            duration = 1; // Default to session
                            break;
                    }

                    // Insert into Subscription table
                    int subscriptionId;
                    using (SqlCommand command = new SqlCommand(subscriptionQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@SubscriptionName", ddlMembershipType.SelectedValue);
                        command.Parameters.AddWithValue("@Payment", txtPayment.Text);
                        command.Parameters.AddWithValue("@Duration", duration);
                        subscriptionId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    // Insert into Transactions table
                    using (SqlCommand command = new SqlCommand(transactionQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@SubscriptionID", subscriptionId);
                        command.Parameters.AddWithValue("@DateofPurchase", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();

                    // Redirect to a success page or display a success message
                    Response.Redirect("SuccessPage.aspx");
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an error occurs
                    transaction.Rollback();

                    // Handle exceptions (e.g., display error message)
                    // You can customize this part based on your application's error handling mechanism
                    // For simplicity, I'm just printing the exception message to the console
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // You can add cancel logic here if needed
        }
    }


}