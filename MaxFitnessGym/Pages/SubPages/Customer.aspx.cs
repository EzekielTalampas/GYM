using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MaxFitnessGym.App_Code;

namespace MaxFitnessGym {
    public partial class Customer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            CustomerData.Fetch();
        }
        protected void btnNewClient_Click(object sender, EventArgs e) {
            Response.Redirect("~/Pages/NewClient/NewClient.aspx");
        }
    }
}