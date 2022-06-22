using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E___ATHENAEUM
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]==null)
                {
                    LinkButton1.Visible = true; //UserLogin
                    LinkButton2.Visible = true; //UserSignUp
                    LinkButton6.Visible = true; //AdminLogin

                    LinkButton3.Visible = false; //LogOut
                    LinkButton7.Visible = false; //HelloUser
                    LinkButton8.Visible = false; //BookInventory
                    LinkButton9.Visible = false; //BookIssuing
                    LinkButton10.Visible = false; //MemberManagement
                    LinkButton11.Visible = false; //AuthorManagement
                    LinkButton12.Visible = false; //PublisherManagement
                }
                else if (Session["role"].Equals("member"))
                {
                    LinkButton3.Visible = true; //LogOut
                    LinkButton7.Visible = true; //HelloUser
                    LinkButton7.Text = "Hello "+Session["fullName"].ToString();

                    LinkButton1.Visible = false; //UserLogin
                    LinkButton2.Visible = false; //UserSignUp
                    LinkButton6.Visible = true; //AdminLogin

                    LinkButton8.Visible = false; //BookInventory
                    LinkButton9.Visible = false; //BookIssuing
                    LinkButton10.Visible = false; //MemberManagement
                    LinkButton11.Visible = false; //AuthorManagement
                    LinkButton12.Visible = false; //PublisherManagement
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton3.Visible = true; //LogOut
                    LinkButton7.Visible = true; //HelloUser
                    LinkButton7.Text = "Hello Admin";

                    LinkButton1.Visible = false; //UserLogin
                    LinkButton2.Visible = false; //UserSignUp
                    LinkButton6.Visible = false; //AdminLogin

                    LinkButton8.Visible = true; //BookInventory
                    LinkButton9.Visible = true; //BookIssuing
                    LinkButton10.Visible = true; //MemberManagement
                    LinkButton11.Visible = true; //AuthorManagement
                    LinkButton12.Visible = true; //PublisherManagement
                }
            }
            catch (Exception exception)
            {

            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorManagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("PublisherManagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookInventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookIssue.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberManagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignUp.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["memberID"] = "";
            Session["fullName"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; //UserLogin
            LinkButton2.Visible = true; //UserSignUp
            LinkButton6.Visible = true; //AdminLogin

            LinkButton3.Visible = false; //LogOut
            LinkButton7.Visible = false; //HelloUser
            LinkButton8.Visible = false; //BookInventory
            LinkButton9.Visible = false; //BookIssuing
            LinkButton10.Visible = false; //MemberManagement
            LinkButton11.Visible = false; //AuthorManagement
            LinkButton12.Visible = false; //PublisherManagement

            Response.Redirect("Home.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }
    }
}