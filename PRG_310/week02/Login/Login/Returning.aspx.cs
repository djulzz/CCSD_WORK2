using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Returning : System.Web.UI.Page
    {
        MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = (MySqlConnection)Session["connection"];
        }
    }
}