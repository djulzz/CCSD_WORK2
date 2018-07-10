using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PRG_310_NIGHT
{
    public partial class Default : System.Web.UI.Page
    {
        MySqlConnection cnx;
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            for( ; i < 101; i += 2 )
            {

            }

            for(; ; )
            {

            }
        }
        {
            //
            String dbName = "LOGIN";
            String connection_params = "Data Source=localhost;\\Database=" + dbName + ";User Id=root;Password=\"\";SSL Mode=None";
            connection = new MySqlConnection(connection_params);
        }
    }
}