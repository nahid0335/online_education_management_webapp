using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Education
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                string email = cookie["Email"];
                string password = cookie["Password"];
                string username = cookie["UserName"];
                string usertype = cookie["UserType"];
                Logic log = new Logic();
                int result = log.LoginCheck(email, password,username,usertype);
                if (result > 0)
                {
                    Session["UserEmail"] = email;
                    Session["UserName"] = username;
                    Session["UserType"] = usertype;
                    Response.Redirect("TempHome.aspx");
                    Session.RemoveAll();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String txtUserType = "student";
            if(!newbie.Checked)
            {
                txtUserType = "teacher";
            }

            Logic log = new Logic();
            int result = log.LoginCheck(txtEmail.Text, txtPassword.Text,txtUserName.Text,txtUserType);
            if (result > 0)
            {
                if (Check1.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserInfo");
                    cookie["Email"] = txtEmail.Text;
                    cookie["UserName"] = txtUserName.Text;
                    cookie["Password"] = txtPassword.Text;
                    cookie["UserType"] = txtUserType;
                    // Cookie will be persisted for 30 days
                    cookie.Expires = DateTime.Now.AddDays(30);
                    // Add the cookie to the client machine
                    Response.Cookies.Add(cookie);
                }
                Session["User"] = txtEmail.Text;
                Session["UserName"] = txtUserName.Text;
                Session["UserType"] = txtUserType;
                Response.Redirect("TempHome.aspx");
                Session.RemoveAll();

            }
            else
            {
                Response.Redirect("ErrorPage.html");
            }
        }

    }
}