using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaxFitnessGym.Pages.LogIn
{
    public partial class logIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "admin123")
            {
                Response.Redirect("/Pages/SubPages/Customer.aspx");
            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "invalidLogin", "alert('Invalid username or password.');", true);
            }
        }
    }
}