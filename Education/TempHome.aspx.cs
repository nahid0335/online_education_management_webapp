using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Education
{
    public partial class TempHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            Session.RemoveAll();
            if (Request.Cookies["UserInfo"] != null)
            {
                HttpCookie myCookie = new HttpCookie("UserInfo");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }
            Response.Redirect("Login.aspx");
        }
    }
}