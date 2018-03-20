using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        //conn_string.Server = "localhost";
        //conn_string.UserID = "root";
        //conn_string.Password = "";
        //conn_string.Database = "OurBoard";
        String cnx = "Database=OurBoard;Data Source=localhost";
        MySqlConnection con = new MySqlConnection( cnx );

        try
        {
            con.Open();
        } catch( Exception ex )
        {
            Response.Write("The connection could not be opened - " + ex.ToString());
        }

        if( con.State == System.Data.ConnectionState.Open )
        {
            Response.Write("Connection established!");
        } else
        {
            Response.Write("Connection Failed!<br/>");
            Response.Write(con.State.ToString() + "<br/>");
        }
    }
}