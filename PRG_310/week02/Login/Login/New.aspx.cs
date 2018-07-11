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
            //TableRow row = new TableRow();
            //TableCell cell_login = new TableCell();
            //cell_login.Text = "Login";
            //row.Cells.Add(cell_login);
            //ThatTableThough.Rows.Add(row);

        }

        protected void Add_New_User(object sender, EventArgs e)
        {
            // Put code for database here
            String s_login = login.Value.ToString();
            String s_passd = password.Value.ToString();
            String s_email = email.Value.ToString();

            String query2 = "INSERT INTO ENTRIES( LOGIN, PASSWORD, EMAIL ) VALUES( " + DB.sc(s_login) + DB.sc(s_passd) + DB.s(s_email) + ");";
            MySqlCommand cmd = new MySqlCommand(query2, connection);
            try
            {
                cmd.ExecuteNonQuery();
                Label_Exception.Text = "Insertion performed correctly";
            } catch ( Exception ex )
            {
                Label_Exception.Text = "Error, cannot insert new user into DB. - Error = " + ex.Message;
            }
        }
    }
}