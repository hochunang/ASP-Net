using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            LogoutLink.Visible = false;
        }
        else
        {
            LogoutLink.Visible = true;
        }
    }

    protected void LogoutLink_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        FormsAuthentication.RedirectToLoginPage();
        //Response.Redirect("Login.aspx");
    }
}
