using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace AirlineSurveys2
{
    public partial class Survey : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection cnx;
            String s = @"Data Source=localhost;Database=flights;User Id=root;Password="";SSL Mode=None";
            cnx = new MySqlConnection(s);
            try
            {

                cnx.Open();
            } catch( Exception ex )
            {
                Response.Write("Error while opening the connection - Reason = " + ex.Message);
                return;
            }

            Session["cnx"] = cnx;
            Response.Redirect("page2.aspx ");

        }
    }
}