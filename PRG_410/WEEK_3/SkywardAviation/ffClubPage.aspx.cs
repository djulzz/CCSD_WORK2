using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if( Profile.flyerID == 0 )
        {
            Response.Redirect("Login.aspx");
        }

        //if (Request.Cookies["flyerID"]== null)

        //    Response.Redirect("Login.aspx");

        else

        {
            SqlConnection dbConnection = new SqlConnection(ConnectionString.Value);
            dbConnection.Open();

            try {
                SqlCommand sqlCommand = new SqlCommand( "SELECT flyerID, first, last FROM FrequentFlyers WHERE flyerID = " 
                    //+ Request.QueryString["flyerID"],
                    + Request.Cookies["flyerID"].Value,
                    dbConnection);
                SqlDataReader userInfo = sqlCommand.ExecuteReader();
                if (userInfo.Read()) {
                    flyerIDValue.Text = userInfo["flyerID"].ToString();
                    firstName.Text = userInfo["first"].ToString();
                    lastName.Text = userInfo["last"].ToString();
                }
                userInfo.Close();
            } catch (SqlException exception) {
                Response.Write("<p>Error code "
                    + exception.Number + ": "
                    + exception.Message + "</p>");
            }
            dbConnection.Close();
        }
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Profile.flyerID = 0;
        //Response.Cookies["flyerID"].Expires = DateTime.Now.AddDays(-1);
        Response.Redirect("Login.aspx");

    }
}
