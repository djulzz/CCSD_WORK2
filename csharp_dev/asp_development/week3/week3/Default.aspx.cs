using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
public partial class _Default : System.Web.UI.Page
{
    MySqlConnection con;
    private bool m_ConnectionOpen;
    protected void Page_Load(object sender, EventArgs e)
    {
        m_ConnectionOpen = false;
        String cnx = "Database=OurBoard;Data Source=localhost;User Id=root;SslMode=none";
        con = new MySqlConnection( cnx );

        try
        {
            con.Open();
            m_ConnectionOpen = true;
        } catch( Exception ex )
        {
            Response.Write("The connection could not be opened - " + ex.ToString());
        }

        if( con.State == System.Data.ConnectionState.Open )
        {
            Response.Write("Connection established!");
            String query = "SELECT * from students";
            MySqlCommand cmd = new MySqlCommand( query, con );
            MySqlDataReader rdr = cmd.ExecuteReader();
            Response.Write("<table>");
            while( rdr.Read() )
            {
                String sId = rdr["student_id"].ToString();
                String fName = rdr["firstName"].ToString();
                String lName = rdr["lastName"].ToString();

                String entry = "<tr>" + "<td>" + sId + "</td>";
                entry += "<td>" + fName + "</td>";
                entry += "<td>" + lName + "</td>" + "</tr>";
                Response.Write(entry);

            }
            rdr.Close();
            Response.Write("</table>");
            Session["MySqlConnection"] = con;
            Session["Last_Error"] = "None";
        } else
        {
            Response.Write("Connection Failed!<br/>");
            Response.Write(con.State.ToString() + "<br/>");
        }
    }

    protected void GoToEnrollStudentPage(object sender, EventArgs e)
    {
        Response.Redirect("EnterNewStudent.aspx");
    }
}