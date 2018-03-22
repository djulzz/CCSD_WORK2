using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class EnterNewStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Add_Student(object sender, EventArgs e)
    {
        MySqlConnection con = (MySqlConnection)Session["MySqlConnection"];
        if (con.State != System.Data.ConnectionState.Open)
        {
            Session["Last_Error"] = "MySqlConnection Was Lost!";
            Response.Redirect("Error.aspx");
            return;
        }

        String FirstName = TextBox_NameFirst.Text;
        String LastName = TextBox_NameLast.Text;

        String query = @"insert into Students(firstName, lastName ) values('" + FirstName + "', '" + LastName + "')";
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("Default.aspx");
        return;
    }
}
