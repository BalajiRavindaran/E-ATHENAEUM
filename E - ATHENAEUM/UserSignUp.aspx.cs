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
    public partial class UserSignUp : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExists())
            {
                Label1.Visible = true;
                Label1.Text = "Member Already Exist with this Member ID, try other ID";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else validation();
        }

        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from member_tbl where member_id='" + TextBox8.Text.Trim() + "';", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");
                return false;
            }
        }

        void NewUserSignUp()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO member_tbl(full_name,dob,contact_no,email,state,city,pincode,full_address,member_id,password,account_status) VALUES(@full_name,@dob,@contact_no,@email,@state,@city,@pincode,@full_address,@member_id,@password,@account_status)", con);
                cmd.Parameters.AddWithValue("@full_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@member_id", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@account_status", "pending");

                cmd.ExecuteNonQuery();
                con.Close();

                Label1.Visible = true;
                Label1.Text = "Sign Up Successful. Go to User Login to Login";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");
            }
        }

        void validation()
        {
            bool containsInt = TextBox9.Text.Trim().Any(char.IsDigit);
            var specialCharacters = new List<string> { "~", "'", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", "/", "?", "<", ">" };
            bool containsSpecialCharacters = specialCharacters.Any(TextBox9.Text.Trim().Contains);


            if (TextBox1.Text.Trim() == null || TextBox1.Text.Trim()=="")
            {
                Label1.Visible = true;
                Label1.Text = "Full Name cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox2.Text.Trim() == null || TextBox2.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "DOB cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox3.Text.Trim() == null || TextBox3.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "Contact Number cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox3.Text.Length < 10)
            {
                Label1.Visible = true;
                Label1.Text = "Contact Number Invalid";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox4.Text.Trim() == null || TextBox4.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "Email cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox5.Text.Trim() == null || TextBox5.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "City cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox6.Text.Trim() == null || TextBox6.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "Pincode cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox7.Text.Trim() == null || TextBox7.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "Full Address cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox8.Text.Trim() == null || TextBox8.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "Member ID cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (TextBox9.Text.Trim() == null || TextBox9.Text.Trim() == "")
            {
                Label1.Visible = true;
                Label1.Text = "Password cannot be empty";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (DropDownList1.SelectedItem.Value== "Select")
            {
                Label1.Visible = true;
                Label1.Text = "Select your appropriate state";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else if(TextBox9.Text.Trim().Length<8 || containsInt==false || containsSpecialCharacters==false)
            {
                Label1.Visible = true;
                Label1.Text = "Password too weak";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                NewUserSignUp();
            }
        }
    }
}