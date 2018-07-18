using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class EditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_login = Request.QueryString["login"];
            string s_pwd   = Request.QueryString["pwd"];
            string s_email = Request.QueryString["email"];

            login.Value = s_login;
            password.Value = s_pwd;
            email.Value = s_email;
        }
    }
}