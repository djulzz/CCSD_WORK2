using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
namespace Intro
{
    public partial class Page02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection query_string = Request.QueryString;
            String statePage01 = query_string["state"];
            bool state_p1_unloaded = (bool)(Session["P1_unloaded"]);
            Response.Write("The state of SQL Connection from Page 01 is: " + statePage01 + "<br/>");
            Response.Write("And Page 1 is " + state_p1_unloaded + "<br/>");
        }
    }
}