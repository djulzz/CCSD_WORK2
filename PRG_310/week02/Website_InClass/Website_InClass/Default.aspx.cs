using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Website_InClass
{
    public partial class Default : System.Web.UI.Page
    {
        private MySqlConnection mConnection;

        protected void Page_Load(object sender, EventArgs e)
        {
            String connection_params = "Data Source=localhost;Database=PRG_310_NIGHT;User Id=root;Password=\"\";SSL Mode=None";
            mConnection = new MySqlConnection(connection_params );
            //try // this is for Exceptions. Id code works, it goes into the try block
            //// if code fails, it goes into the "catch" bucket
            //{
            //    mConnection.Open();
            //    if (mConnection.State == ConnectionState.Open)
            //    {
            //        Response.Write("CNX Established!<br/>");
            //    }
            //}

        }
    }
}