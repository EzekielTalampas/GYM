using System;
using System.Data.SqlClient;
using System.Web.Hosting;

namespace MaxFitnessGym
{
    public partial class NewClient : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Define connection string
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{HostingEnvironment.MapPath("/")}App_Data\GymDB.mdf"";Integrated Security=True";

            // Define the SQL query for inserting into the Customer table
            string customerQuery = "INSERT INTO Customer (ID, LastName, FirstName, PhoneNumber) VALUES (@ID, @LastName, @FirstName, @PhoneNumber)";

            // Create connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Start a transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int customerId;
                    using (SqlCommand command = new SqlCommand(customerQuery, connection, transaction))
                    {
                        // Generate a unique ID
                        int generatedId = GenerateUniqueID();
                        command.Parameters.AddWithValue("@ID", generatedId);
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Set the generated ID as customerId
                        customerId = generatedId;
                    }

                    // Commit the transaction
                    transaction.Commit();

                    // Display success message
                    lblMessage.Text = "New client added successfully with ID: " + customerId;
                    
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an error occurs
                    transaction.Rollback();

                    // Handle exceptions
                    lblMessage.Text = "Error: " + ex.Message;
                }
               
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/SubPages/Customer.aspx");
        }

        // Method to generate a unique ID
        private int GenerateUniqueID()
        {
            // Use a combination of timestamp and randomness to generate a unique ID
            // This is just a sample implementation, replace it with your own logic
            Random random = new Random();
            return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds + random.Next(1000, 9999);
        }


    }
}
