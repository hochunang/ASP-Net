using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        loginForm.Visible = true;
        signupForm.Visible = false;

        if (Session["username"] != null)
        {
            Response.Redirect("~/Dashboard.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);
        try
        {
            con.Open();
            SqlCommand cmd =
                new SqlCommand(
                    "select count(*) from admin where username='" + username.Text + "' and password='" + password.Text +
                    "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows[0][0].ToString() == "1")
            {
                Session["username"] = username.Text.Trim();
                FormsAuthentication.RedirectFromLoginPage(username.Text, true);
                //Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid login')</script");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(constr);

        try
        {
            con.Open();
            SqlCommand cmd =
                new SqlCommand(
                    "insert into admin values('" + usernameSign.Text + "' , '" + passwordSign.Text + "');", con);

            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            usernameSign.Text = "";
            passwordSign.Text = "";


            Response.Write("<script>alert('Successful sign up')</script");


        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        loginForm.Visible = true;
        signupForm.Visible = false;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        loginForm.Visible = false;
        signupForm.Visible = true;
    }
}