using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Education
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String txtUserType = "student";
            if (!newbie.Checked)
            {
                txtUserType = "teacher";
            }

            Logic log = new Logic();
            int result = log.LoginCheck(txtEmail.Text, txtPassword.Text, txtUserName.Text, txtUserType);
            if (result > 0)
            {
                //error
                Response.Redirect("ErrorPage.html");

            }
            else
            {
                int value = log.InsertUserInfo(txtUserName.Text, txtEmail.Text, txtPassword.Text, txtUserType);
                if (value > 0)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    //error
                    Response.Redirect("ErrorPage.html");
                }
                
            }
        }
    }
}