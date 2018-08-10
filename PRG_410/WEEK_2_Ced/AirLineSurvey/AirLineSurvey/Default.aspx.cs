using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace AirLineSurvey
{
    public enum Survey_Criteria
    {
        R_cleanliness = 0,
        R_friendly = 1,
        R_noise = 2,
        R_space = 3,
        R_comfort = 4
    }

    public enum Qualifier
    {
        No_Opinion = 0,
        Poor = 1,
        Fair = 2,
        Good = 3,
        Excellent = 4
    }

    public partial class Default : System.Web.UI.Page
    {
        Dictionary<Survey_Criteria, Qualifier> mReviews;
        MySqlConnection mConnection;

        public static String s(String i )
        {
            return "'" + i + "'";
        }

        public Survey_Criteria StringToEnum(String review)
        {
            Survey_Criteria sc = Survey_Criteria.R_cleanliness;
            switch (review)
            {
                case "R_Comfort": { sc = Survey_Criteria.R_comfort; } break;
                case "R_Clean": { sc = Survey_Criteria.R_cleanliness; } break;
                case "R_Friendly": { sc = Survey_Criteria.R_friendly; } break;
                case "R_Space": { sc = Survey_Criteria.R_space; } break;
                case "R_Noise": { sc = Survey_Criteria.R_noise; } break;
                default: break;
            }
            return sc;
        }


        public Qualifier StringToQualifier(String qualifier)
        {
            Qualifier q = Qualifier.No_Opinion;
            switch (qualifier)
            {
                case "No Opinion": { q = Qualifier.No_Opinion; } break;
                case "Poor": { q = Qualifier.Poor; } break;
                case "Fair": { q = Qualifier.Fair; } break;
                case "Good": { q = Qualifier.Good; } break;
                case "Excellent": { q = Qualifier.Excellent; } break;
                default: break;
            }
            return q;
        }

        protected void Handle_Rating(object sender, EventArgs e)
        {
            RadioButtonList rbl = (RadioButtonList)sender;
            String Criteria = rbl.ID;
            String Qualifier = rbl.SelectedItem.Text;
            ListItem li = ListBox_Flights.SelectedItem;
            if( li != null )
            {
                String flight_caption = li.Text;
                char[] separator = { '|' };
                String[] elements = flight_caption.Split(separator);
                String flight_number = elements[0];
                String airline = elements[1];

                Survey_Criteria criteria = StringToEnum(Criteria);
                Qualifier qual = StringToQualifier(Qualifier);
                mReviews = ( Dictionary<Survey_Criteria, Qualifier>) Session["review"];
                mReviews.Add(criteria, qual);
                if (mReviews.Count == 5)
                {
                    String query = "INSERT INTO SURVEY";

                    int friendliness = (int)mReviews[Survey_Criteria.R_friendly];
                    int space = (int)mReviews[Survey_Criteria.R_space];
                    int comfort = (int)mReviews[Survey_Criteria.R_comfort];
                    int cleanliness = (int)mReviews[Survey_Criteria.R_cleanliness];
                    int noise = (int)mReviews[Survey_Criteria.R_noise];

                    query += "(flight_number, airline_code, friendliness, space, confort, cleanliness, noise)";
                    query += " values(" + flight_number + ", " + s(airline) + ", " + friendliness + ", " + space + ", " + comfort + ", " + cleanliness + ", " + noise + ")";
                    mConnection = (MySqlConnection)Session["cnx"];
                    MySqlCommand cmd = new MySqlCommand(query, mConnection);
                    cmd.ExecuteNonQuery();
                }



                int c = 5;
            }
            int a = 2;
            return;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { // if the page is loading for the first time
                mConnection = new MySqlConnection();
                mReviews = new Dictionary<Survey_Criteria, Qualifier>();
                Session["review"] = mReviews;
                String ConnectionParams = "Data Source=localhost;Database=flights;User Id=root;Password=\"\";SSL Mode=None";
                bool errorEncoutered = false;
                mConnection.ConnectionString = ConnectionParams;
                try
                {
                    mConnection.Open();
                    Session["cnx"] = mConnection;
                }
                catch (Exception ex)
                {
                    errorEncoutered = true;
                    Response.Write("Error - Exception says = " + ex.Message);
                    return;
                }
                // if no error / no exception were encountered, we
                // further double check our connection to the datatabase
                // by inspection its State property
                if (errorEncoutered == false)
                {
                    if (mConnection.State == System.Data.ConnectionState.Open)
                    {
                        Response.Write("Conection established");
                    }
                }

                String query = "SELECT * FROM DETAILS";
                MySqlCommand cmd = new MySqlCommand(query, mConnection);

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    if( rdr.Read() )
                    {
                        do
                        {
                            int flight_number = (int)rdr["flight_number"];
                            String Airline = (String)rdr["airline_code"];
                            DateTime departure = (DateTime)rdr["departure_time"];
                            DateTime arrival = (DateTime)rdr["arrival_time"];
                            String departure_loc = (String)rdr["departure"];
                            String arrival_loc = (String)rdr["arrival"];

                            String s = "|";
                            String Caption = flight_number + s + Airline + s + departure + s + arrival + s + departure_loc + s + arrival_loc;
                            ListItem li = new ListItem();
                            li.Text = Caption;
                            ListBox_Flights.Items.Add(li);
                        } while (rdr.Read());
                    }
                }

                List<RadioButtonList> lst = new List<RadioButtonList>();
                lst.Add(R_Noise);
                lst.Add(R_Space);
                lst.Add(R_Comfort);
                lst.Add(R_Clean);
                lst.Add(R_Friendly);

                for( int i = 0; i < 5; i++ )
                {
                    lst[i].Items.Add("No Opinion");
                    lst[i].Items.Add("Poor");
                    lst[i].Items.Add("Fair");
                    lst[i].Items.Add("Good");
                    lst[i].Items.Add("Excellent");
                }
                //ListBox_Flights.
            }
        }
    }
}