using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
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

        protected void UpdateEntry_ServerClick(object sender, EventArgs e)
        {
            String s_login, s_password, s_email;
            s_login = login.Value;
            s_password = password.Value;
            s_email = email.Value;

            
            MySqlConnection c = (MySqlConnection)Session["connection"];
            String q = "";
            q += "SELECT ID, LOGIN, PASSWORD, EMAIL FROM ENTRIES ";
            q += "WHERE ";
            q += "(LOGIN = " + s_login + ") ";
            q += "AND ";
            q += "(PASSWORD = " + s_password + ") ";
            q += "AND ";
            q += "(EMAIL = " + s_email + ")";

            MySqlCommand cmd = new MySqlCommand(q, c);
            using( MySqlDataReader r = cmd.ExecuteReader() )
            {
                bool found = false;
                found = false;
                if( r.HasRows )
                {
                    found = true;
                }
            }
            
            return;
        }
    }
}