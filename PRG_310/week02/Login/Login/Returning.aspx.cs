using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

using System.Data;

namespace Login
{
    public partial class Returning : System.Web.UI.Page
    {
        MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = (MySqlConnection)Session["connection"];
            if( connection.State == ConnectionState.Open)
            {
                ;
            } else
            {
                Response.Write("connection broken");
            }
        }
        protected void Process_Returning_Customer( object sender, EventArgs e )
        {
            String s_login = login.Value;
            String s_pwd = password.Value;
            String s_email = email.Value;

            String potential_error = "";
            if( DB.UserExists(s_login, s_pwd, s_email, ref connection, out potential_error) )
            {
                login.Value = "Exists!!!!";
            }
        }
    }
}