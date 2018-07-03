using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Intro
{
    public partial class Page01 : System.Web.UI.Page
    {
        private MySqlConnection mConnection;

        protected void Page_Unload(object sender, EventArgs e)
        {
            mConnection.Close();
            Session["P1_unloaded"] = true;

        }

        protected void Load_Students()
        {
            String query_string = "SELECT * FROM students";
            MySqlCommand cmd = new MySqlCommand(query_string, mConnection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if( rdr.Read() )
            {
                Response.Write("<table>");
                do
                {
                    int id = ( int )( rdr["ID"] );
                    String FN = (String)(rdr["First_Name"]);
                    String LN = (String)(rdr["Last_Name"]);
                    int ID = (int)(rdr["ID"]);
                    
                    Response.Write("<tr>");
                    Response.Write("<td>");
                    Response.Write(FN);
                    Response.Write("</td>");
                    Response.Write("<td>");
                    Response.Write(LN);
                    Response.Write("</td>");
                    Response.Write("<td>");
                    Response.Write(ID);
                    Response.Write("</td>");
                    Response.Write("</tr>");
                    
                } while (rdr.Read());
                
            }
            Response.Write("</table>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mConnection = new MySqlConnection( "Data Source=localhost;Database=course;User Id=root;Password=\"\";SSL Mode=None");
            try {
                mConnection.Open();
                if (mConnection.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("CNX Success!");
                }
            } catch( Exception exe ) 
            {
                Response.Write("CNX could not be established - Reason:" + exe.Message );
            }

            // Creating a session variable
            Session["P1_unloaded"] = false;
            Load_Students();
        }


        protected void GoToNextPage(object sender, EventArgs e)
        {
            String cnx_state = "closed";
            if (mConnection.State == System.Data.ConnectionState.Open)
            {
                cnx_state = "open";
            }
            Response.Redirect("Page02.aspx?state="+ cnx_state);
        }

        protected void Edit_Students(object sender, EventArgs e)
        {

        }
    }
}