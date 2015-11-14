using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColorWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.RadioButtonList1.SelectedValue == "Red")
            {
                Response.Redirect("Red.aspx");
            }
            else if (this.RadioButtonList1.SelectedValue == "Blue")
            {
                Response.Redirect("Blue.aspx");
            }
            else
                {
                Response.Redirect("Green.aspx");
            }
        }
    }
}