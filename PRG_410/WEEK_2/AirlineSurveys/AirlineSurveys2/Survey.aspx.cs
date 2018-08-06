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
        private MySqlConnection cnx;

        protected void HandleClick(object sender, EventArgs e)
        {
            RadioButtonList rbl = (RadioButtonList)sender;
            int ba = 2;
            switch( rbl.ID )
            {
                case "R_friendly":
                {
                   String selection = rbl.SelectedItem.Text;
                   Session["R_friendly"] = selection;
                   //Response.Write(selection);
                   //String s = (String)Session["R_friendly"];
                } break;
                case "R_space": {; } break;
                case "R_comfort": {; } break;
                case "R_cleanliness": {; } break;
                case "R_noise": {;  } break;
            }
            //Response.Write( R1.SelectedItem.Text );
            //Button b = (Button)sender;
            int a = 0;
            //if (b.ID == "f0")
            //{
            //    Response.Write("You Clicked it!");
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                //String connection_params = "Data Source=localhost;Database=PRG_310_NIGHT;User Id=root;Password=\"\";SSL Mode=None";
                String connection_params = "Data Source=localhost;Database=flights;User Id=root;Password=\"\";SSL Mode=None";

                cnx = new MySqlConnection(connection_params);
                try
                {

                    cnx.Open();
                }
                catch (Exception ex)
                {
                    Response.Write("Error while opening the connection - Reason = " + ex.Message);
                    return;
                }

                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Connection Successful");
                    String query = "SELECT * FROM details";
                    MySqlCommand cmd = new MySqlCommand(query, cnx);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        ///todays_flight_list.Rows
                        if (rdr.Read())
                        {
                            do
                            {
                                int a1 = (int)rdr["flight_number"];
                                String s2 = (String)rdr["airline_code"];
                                DateTime s3 = (DateTime)rdr["departure_time"];
                                DateTime s4 = (DateTime)rdr["arrival_time"];
                                String s5 = (String)rdr["departure"];
                                String s6 = (String)rdr["arrival"];

                                String entry = Convert.ToString(a1);
                                entry += " - " + s2;
                                entry += " - " + s3;
                                entry += " - " + s4;
                                entry += " - " + s5;
                                entry += " - " + s6;

                                ListItem li = new ListItem();
                                li.Text = entry;
                                ListBox1.Items.Add(li);
                            } while (rdr.Read());


                        }
                    }
                }
                else
                {
                    Response.Write("Connection Un - successful");
                    Session["cnx"] = cnx;
                }

                List<RadioButtonList> lst = new List<RadioButtonList>();
                lst.Add(R_friendly);
                lst.Add(R_space);
                lst.Add(R_comfort);
                lst.Add(R_cleanliness);
                lst.Add(R_noise);

                for( int i = 0; i < 5; i++ )
                {
                    lst[i].Items.Add("No Opinion");
                    lst[i].Items.Add("Poor");
                    lst[i].Items.Add("Fair");
                    lst[i].Items.Add("Good");
                    lst[i].Items.Add("Excellent");
                    lst[i].SelectedIndexChanged += new EventHandler(HandleClick);
                }
            } else // if the page is being re - posted
            {
                String s = (String)Session["R_friendly"];
                Label_Feeback.Text = s;

            }

            R_friendly.SelectedIndexChanged += new EventHandler(HandleClick);

        }
    }
}