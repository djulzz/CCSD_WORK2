using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Default : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !Page.IsPostBack ) { // if this is the 1st time we are loading
                                     // the page

                    String dbName = "LOGIN";
                String connection_params = "Data Source=localhost;Database=";
                connection_params += dbName;
                connection_params += ";User Id=root;Password=\"\";SSL Mode=None";
                    connection = new MySqlConnection(connection_params);
                    try // try is the Place Holder for code that does work
                    {
                        connection.Open();
                        Session["connection"] = connection;

                    }
                    catch (Exception ex)
                    {
                        Label_Error.Text = "Error - Message = " + ex.Message;
                    }
                }
            Label_Error.Text = "In Default.aspx, the connection was created successfully";
        }

        protected void Handle_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if( btn.Text == "Returning User" )
            {
                Response.Redirect("Returning.aspx");
            }
            else
            {
                Response.Redirect("New.aspx");
            }
        }
    }
}