using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaxFitnessGym.App_Code;

namespace MaxFitnessGym
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomers();
            }
        }

        // Method to load customers
        private void LoadCustomers()
        {
            string query = (txtSearch.Text == string.Empty) ? "SELECT * FROM Customer ORDER BY FirstName DESC" : $"SELECT * FROM Customer WHERE FirstName LIKE '%{txtSearch.Text}%'";
            CustomerData.Fetch(query);
            BindCustomerList();
        }

        // Method to bind customer data to the UI
        private void BindCustomerList()
        {
            rptCustomers.DataSource = CustomerData.List;
            rptCustomers.DataBind();
        }

        protected void btnNewClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/NewClient/NewClient.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Implement update functionality if needed
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            int customerId = Convert.ToInt32(btnDelete.CommandArgument);

            // Call the method to delete the customer from the database
            bool success = CustomerData.DeleteCustomer(customerId);

            if (success)
            {
                // Reload customers after deletion
                LoadCustomers();
            }

        }

        protected void rptCustomers_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                CustomerData customer = (CustomerData)e.Item.DataItem;
                Button btnDelete = (Button)e.Item.FindControl("btnDelete");
                btnDelete.CommandArgument = customer.ID.ToString();
            }
        }
    }
}