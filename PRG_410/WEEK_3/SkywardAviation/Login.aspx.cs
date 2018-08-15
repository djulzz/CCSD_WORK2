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

        if (Page.IsPostBack)

        {
            SqlConnection dbConnection = new SqlConnection(ConnectionString.Value);
            //SqlConnection dbConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Course Technology\\0324 - 2\\Chapter.09\\Chapter\\SkywardAviation\\App_Data\\SkywardAviation.mdf; Integrated Security = True; User Instance = True");
            try

            {

                dbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand( "SELECT flyerID, first, last, password FROM FrequentFlyers WHERE flyerID = "  + Convert.ToInt16(account.Text) + " AND password = '" + password.Text + "'", dbConnection);
                SqlDataReader curUser = sqlCommand.ExecuteReader();
                if (curUser.Read())
                {

                    Profile.flyerID = (int)curUser["flyerID"];
                    //HttpCookie flyerIDObject = new HttpCookie("flyerID");
                    //flyerIDObject.Value = curUser["flyerID"].ToString();
                    //flyerIDObject.Expires = DateTime.Now.AddDays(30);
                    //Response.Cookies.Add(flyerIDObject);
                    Response.Redirect("ffClubPage.aspx");
                    Response.Redirect("ffClubPage.aspx?flyerID=" + curUser["flyerID"]);
                }
                else
                    badLogin.Text = "<p style='color:red'> < strong > Incorrect ID or password. < strong ></ p > ";

            } catch (SqlException exception) {
                Response.Write("<p>Error code " + exception.Number + ": " + exception.Message + "</p>");
            }
            dbConnection.Close();
        }
    }
}
