using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E___ATHENAEUM
{
    public partial class UserLogin : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (validations())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strCon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * FROM member_tbl WHERE member_id='" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "';", con);
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Response.Write("<script>alert('Login Successful');</script>");
                            Session["memberID"] = dataReader.GetValue(8).ToString();
                            Session["fullName"] = dataReader.GetValue(0).ToString();
                            Session["role"] = "member";
                            Session["status"] = dataReader.GetValue(10).ToString();
                        }
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.ForeColor = System.Drawing.Color.Red;
                        Label1.Text = "Invalid credentials";
                    }
                }
                catch (Exception exception)
                {
                    Response.Write("<script>alert('" + exception.Message + "');</script>");
                }
            }
            else
            {
                if (TextBox1.Text.Trim() == null || TextBox1.Text.Trim() == "")
                {
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Member ID cannot be empty";
                }
                else if (TextBox2.Text.Trim() == null || TextBox2.Text.Trim() == "")
                {
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Password cannot be empty";
                }
            }

        }

        bool validations()
        {
            if ((TextBox1.Text.Trim() == null || TextBox1.Text.Trim() == "") || (TextBox2.Text.Trim() == null || TextBox2.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}