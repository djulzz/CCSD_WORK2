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
            //Response.Write("<table>");
            while( rdr.Read() )
            {
                TableRow tempRow = new TableRow();

                String sId = rdr["student_id"].ToString();
                String fName = rdr["firstName"].ToString();
                String lName = rdr["lastName"].ToString();


                TableCell c1 = new TableCell();
                Button b1 = new Button();
                b1.Click += HandleAllClicks;
                b1.Text = sId;
                c1.Controls.Add( b1 );

                TableCell c2 = new TableCell();
                c2.Text = fName;
                TableCell c3 = new TableCell();
                c3.Text = lName;

                tempRow.Cells.Add(c1);
                tempRow.Cells.Add(c2);
                tempRow.Cells.Add(c3);

                Table1.Rows.Add(tempRow);

                //Button b = new Button();
                //b.Text = fName;

                //String entry = "<tr>" + "<td>" + sId + "</td>";
                //entry += "<td>" + fName + "</td>";
                //entry += "<td>" + lName + "</td>" + "</tr>";
                //Response.Write(entry);

            }
            rdr.Close();
            //Response.Write("</table>");
            Session["MySqlConnection"] = con;
            Session["Last_Error"] = "None";
        } else
        {
            Response.Write("Connection Failed!<br/>");
            Response.Write(con.State.ToString() + "<br/>");
        }
    }
    protected void HandleAllClicks(object sender, System.EventArgs e)
    {
        Button btn = (Button)sender;
        String student_id = btn.Text;
        String query = "select * from students where student_id = " + student_id;
        MySqlCommand cmd = new MySqlCommand(query, con);
        MySqlDataReader rdr = cmd.ExecuteReader();
        String parameters = "";
        while (rdr.Read())
        {
            int student_id_from_reader = (int)rdr["student_id"];
            String firtName = (String)rdr["firstName"];
            String lastName = (String)rdr["lastName"];
            parameters = "?student_id=" + Convert.ToString(student_id_from_reader) + "&";
            parameters += "firstName=" + firtName + "&";
            parameters += "lastName=" + lastName;
            
            break;
        }
        rdr.Close(); // MAKE SURE YOU CLOSE YOUR READER
        Response.Redirect("StudentEditor.aspx" + parameters);
        // Add event handler code here.  
    }
    protected void GoToEnrollStudentPage(object sender, EventArgs e)
    {
        Response.Redirect("EnterNewStudent.aspx");
    }
}