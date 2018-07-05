using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace Login
{
    public partial class New : System.Web.UI.Page
    {
        MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            // retriving connection
            connection = (MySqlConnection)(Session["connection"]);
        }

        protected void Add_New_User(object sender, EventArgs e)
        {
            // Put code for database here
        }
    }
}