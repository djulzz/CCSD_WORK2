using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace AirlineSurveys3
{
    public enum Survey_Criteria
    {
        R_cleanliness   = 0,
        R_friendly      = 1,
        R_noise         = 2,
        R_space         = 3,
        R_comfort       = 4
    }

    public enum Qualifier
    {
        No_Opinion      = 0,
        Poor            = 1,
        Fair            = 2,
        Good            = 3,
        Excellent       = 4
    }

    public class Review_Data : Dictionary< Survey_Criteria, Qualifier>
    {
    }

    public partial class Tutorial2 : System.Web.UI.Page
    {
        private static String SURVEY_READY_FOR_SUBMISSION = "SURVEY_READY_FOR_SUBMISSION";
        private MySqlConnection mConnection;
        private Review_Data mSurveyData;

        public Survey_Criteria StringToEnum( String review )
        {
            Survey_Criteria sc = Survey_Criteria.R_cleanliness;
            switch( review )
            {
                case "R_Comfort" : { sc = Survey_Criteria.R_comfort; } break;
                case "R_Cleanliness": { sc = Survey_Criteria.R_cleanliness; } break;
                case "R_Friendliness": { sc = Survey_Criteria.R_friendly; } break;
                case "R_Space": { sc = Survey_Criteria.R_space; } break;
                case "R_Noise": { sc = Survey_Criteria.R_noise; } break;
                default: break;
            }
            return sc;
        }


        public Qualifier StringToQualifier( String qualifier )
        {
            Qualifier q = Qualifier.No_Opinion;
            switch( qualifier )
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

        protected void Page_Load(object sender, EventArgs e)
        {
            mSurveyData = new Review_Data();

            if ( !Page.IsPostBack ) // if the page is loading for the first time
                                   // do the GUI initialization there

            {
                String connection_params = "Data Source=localhost;Database=flights;User Id=root;Password=\"\";SSL Mode=None";
                mConnection = new MySqlConnection(connection_params );
                mConnection.Open();
                String query = "SELECT * FROM details";
                MySqlCommand cmd = new MySqlCommand(query, mConnection );
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    int count = 1;
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
                            String background_color = "grey";
                            if (count % 2 == 0)
                            {
                                background_color = "coral";
                            }
                            li.Attributes.CssStyle.Add("background-color", background_color);
                            count++;
                            FlightSelection.Items.Add(li);
                        } while (rdr.Read());


                    }
                }
                List<RadioButtonList> lst = new List<RadioButtonList>();
                lst.Add(R_Cleanliness);
                lst.Add(R_Comfort);
                lst.Add(R_Friendliness);
                lst.Add(R_Noise);
                lst.Add(R_Space);

                for( int i = 0; i < 5; i++ )
                {
                    lst[i].Items.Add("No Opinion");
                    lst[i].Items.Add("Poor");
                    lst[i].Items.Add("Fair");
                    lst[i].Items.Add("Good");
                    lst[i].Items.Add("Excellent");
                }
            }
        }

        protected void Handle_Click(object sender, EventArgs e)
        {
            RadioButtonList rbl = (RadioButtonList)sender;
            String RadioButtonListID = rbl.ID; // Comfort, Noise, etc...
            String selection = rbl.SelectedItem.Text; // Poor, Fair, etc..
            Survey_Criteria criteria = StringToEnum(RadioButtonListID);
            Qualifier q = StringToQualifier(selection);
            mSurveyData.Add(criteria, q);
            if (mSurveyData.Count == 5) // we are ready to submit our data
                Session[SURVEY_READY_FOR_SUBMISSION] = true;
            else
                Session[SURVEY_READY_FOR_SUBMISSION] = false;
        }

        protected void Submit_Review(object sender, EventArgs e)
        {
            bool submit_state = (bool)Session[SURVEY_READY_FOR_SUBMISSION];
            if( submit_state == true )
            {
                int rating_comfort = (int)mSurveyData[Survey_Criteria.R_cleanliness];
                int rating_noise = (int)mSurveyData[Survey_Criteria.R_noise];
                int rating_friendly = (int)mSurveyData[Survey_Criteria.R_friendly];
                int rating_clean = (int)mSurveyData[Survey_Criteria.R_cleanliness];
                int rating_space = (int)mSurveyData[Survey_Criteria.R_space];

                String SQL_query = "INSERT INTO SURVEY( FLIGHT_NUMBER, AIRLINE_CODE, FRIENDLINESS, SPACE, CONFORT, CLEANLINESS, NOISE) VALUES( 1112, 'AA', ";
                SQL_query += rating_friendly + ", ";
                SQL_query += rating_space + ", ";
                SQL_query += rating_comfort + ", ";
                SQL_query += rating_clean + ", ";
                SQL_query += rating_noise + ")";

                // last step, clear survey data
                mSurveyData.Clear();
            }
        }
    }
}