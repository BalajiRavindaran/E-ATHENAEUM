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
    public partial class AuthorManagement : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        // add
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkAuthorExists())
            {
                Response.Write("<script>alert('Author already exist');</script>");
            }
            else
            {
                validations();
            }
        }
        // update
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkAuthorExists())
            {
                updateAuthor();
            }
            else
            {
                Response.Write("<script>alert('Author does not exist');</script>");
            }
        }
        // delete
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkAuthorExists())
            {
                deleteAuthor();
            }
            else
            {
                Response.Write("<script>alert('Author does not exist');</script>");
            }
        }
        // go
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getAuthorById();
        }

        void getAuthorById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from author_tbl where author_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Author ID');</script>");
                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");

            }
        }

        void deleteAuthor()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM author_tbl WHERE author_id='" + TextBox1.Text.Trim() + "' ", con);

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Author deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");
            }
        }

        void updateAuthor()
        {
            if (TextBox2.Text.Trim() == null || TextBox2.Text.Trim() == "")
            {
                Response.Write("<script>alert('Author Name cannot be empty');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strCon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE author_tbl SET author_name=@author_name WHERE author_id='" + TextBox1.Text.Trim() + "' ", con);
                    cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Author Updated Successfully');</script>");
                    clearForm();
                    GridView1.DataBind();
                }
                catch (Exception exception)
                {
                    Response.Write("<script>alert('" + exception.Message + "');</script>");
                }
            }

        }

        void addAuthor()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO author_tbl(author_id,author_name) VALUES(@author_id,@author_name)", con);
                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Author Added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");
            }
        }

        bool checkAuthorExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from author_tbl where author_id='" + TextBox1.Text.Trim() + "';", con);
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

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void validations()
        {
            if (TextBox1.Text.Trim() == null || TextBox1.Text.Trim() == "")
            {
                Response.Write("<script>alert('Author ID cannot be empty');</script>");
            }

            else if (TextBox2.Text.Trim() == null || TextBox2.Text.Trim() == "")
            {
                Response.Write("<script>alert('Author Name cannot be empty');</script>");
            }

            else
            {
                addAuthor();
            }
        }
    }
}