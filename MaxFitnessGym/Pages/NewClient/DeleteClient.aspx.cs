using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaxFitnessGym
{
    public partial class DeleteClient : System.Web.UI.Page

    {
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/SubPages/Customer.aspx");
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Define connection string
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{HostingEnvironment.MapPath("/")}App_Data\GymDB.mdf"";Integrated Security=True";

            // Define the SQL query for deleting from the Customer table
            string deleteCustomerQuery = "DELETE FROM Customer WHERE ID = @ID";

            // Define the SQL query for deleting from the Transaction table
            string deleteTransactionQuery = "DELETE FROM Transactions WHERE Customer = @CustomerID";

            // Extract client ID from the textbox
            string clientId = txtEnterID.Text.Trim();

            // Create connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Start a transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Execute the delete query for 'Transactions' table
                    using (SqlCommand command = new SqlCommand(deleteTransactionQuery, connection, transaction))
                    {
                        // Set the parameter value
                        command.Parameters.AddWithValue("@CustomerID", clientId);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }

                    // Execute the delete query for 'Customer' table
                    using (SqlCommand command = new SqlCommand(deleteCustomerQuery, connection, transaction))
                    {
                        // Set the parameter value
                        command.Parameters.AddWithValue("@ID", clientId);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();

                    // Display success message
                    lblDeleteMessage.Text = "Client data deleted successfully.";
                    lblDeleteMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an error occurs
                    transaction.Rollback();

                    // Handle exceptions
                    lblDeleteMessage.Text = "Error: " + ex.Message;
                    lblDeleteMessage.Visible = true;
                }

            }
        }
    }
}