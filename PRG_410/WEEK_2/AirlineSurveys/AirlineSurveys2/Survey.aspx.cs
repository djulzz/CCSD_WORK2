﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace AirlineSurveys2
{

    enum Survey_Criteria
    {
        R_cleanliness = 0,
        R_friendly = 1,
        R_noise = 2,
        R_space = 3,
        R_comfort = 4
    }

    enum Qualifier
    {
        No_Opinion = 0,
        Excellent
    }
    public partial class Survey : System.Web.UI.Page
    {
        private MySqlConnection cnx;
        private Dictionary<Survey_Criteria, RadioButtonList> mLists;

        public Survey() : base()
        {

        }
        public String Message
        {
            set
            {
                Session["message_prev"] = Session["message"];
                Session["message"] = value;
            }

            get
            {
                return (String)Session["message_prev"];
            }
        }

        public String Time
        {
            get
            {
                String result = "";
                DateTime dt = DateTime.Now;
                result = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
                return result;
            }
        }

        public void WriteToDebugDiv( String message )
        {

            String myColor = "white";
            switch (message)
            {
                case "Page_PreInit": { myColor = "green"; } break;
                case "Page_Init": { myColor = "darkolivegreen"; } break;
                case "Page_InitComplete": { myColor = "yellow"; } break;
                case "Page_PreLoad": { myColor = "orange"; } break;
                case "Page_Load": { myColor = "darkorange"; } break;
                case "Page_LoadComplete": { myColor = "orangered"; } break;
                case "Page_PreRender": { myColor = "darkblue"; } break;
                case "Page_PreRenderComplete": { myColor = "blue"; } break;
                case "Page_Render": { myColor = "lightblue"; } break;
                case "Page_SaveStateComplete": { myColor = "blueviolet"; } break;
                
                case "Page_Unload": { myColor = "red"; } break;
                default: break;
            }
            String res = Time + " - " + message;
            ListItem li = new ListItem();
            li.Text = res;
            li.Attributes.CssStyle.Add("color", myColor);
            lbDebug.Items.Add( li );

            return;
        }

        protected void WriteMessageToFooter( String message )
        {
            Label_Feeback.Text = message;
            return;
        }

        protected void HandleClick(object sender, EventArgs e)
        {
            //if( sender.ToString() != "System.Web.UI.WebControls.RadioButtonList" )
            //{
            //    // This is absolutely unnecessary, but guarantees that the
            //    // sender is always
            //    return;
            //}
            
            RadioButtonList rbl = (RadioButtonList)sender;
            
            String RadioButtonList_selected = rbl.ID;
            String selection = rbl.SelectedItem.Text;
            String msg = RadioButtonList_selected + "\t" + selection;
            Session["new_message"] = msg;
        }

        public void Writeback_SurveySelection( )
        {
            lbl_survey_current_selection.Text = (String)Session["new_message"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mLists = new Dictionary<Survey_Criteria, RadioButtonList>();
            mLists.Add(Survey_Criteria.R_cleanliness, R_cleanliness);
            mLists.Add(Survey_Criteria.R_friendly, R_friendly);
            mLists.Add(Survey_Criteria.R_noise, R_noise);
            mLists.Add(Survey_Criteria.R_space, R_space);
            mLists.Add(Survey_Criteria.R_comfort, R_comfort);

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
                    Message = "Error while opening the connection -Reason = " + ex.Message;
                    return;
                }

                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    Message = "Connection Successful";
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
                } // END OF IF THE CONNECTION IS OPEN
                else
                {
                    Message = "Connection Un - successful";
                    Session["cnx"] = cnx;
                }

                
                for( int i = 0; i < 5; i++ )
                {
                    mLists[(Survey_Criteria)i].Items.Add("No Opinion");
                    mLists[(Survey_Criteria)i].Items.Add("Poor");
                    mLists[(Survey_Criteria)i].Items.Add("Fair");
                    mLists[(Survey_Criteria)i].Items.Add("Good");
                    mLists[(Survey_Criteria)i].Items.Add("Excellent");
                    mLists[(Survey_Criteria)i].SelectedIndexChanged += new EventHandler(HandleClick);
                }
            } // END OF ( if !Page.IsPostBack )
            else
            {
                mLists[Survey_Criteria.R_friendly].SelectedIndexChanged     += new EventHandler(HandleClick);
                mLists[Survey_Criteria.R_space].SelectedIndexChanged        += new EventHandler(HandleClick);
                mLists[Survey_Criteria.R_comfort].SelectedIndexChanged      += new EventHandler(HandleClick);
                mLists[Survey_Criteria.R_cleanliness].SelectedIndexChanged  += new EventHandler(HandleClick);
                mLists[Survey_Criteria.R_noise].SelectedIndexChanged        += new EventHandler(HandleClick);
            }


            WriteMessageToFooter(Message);
            WriteToDebugDiv("Page_Load");

        }


        protected void Page_PreInit(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_PreInit");
            return;
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_Init");
            return;
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_InitComplete");
            return;
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_PreLoad");
            return;
        }


        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_LoadComplete");
            Writeback_SurveySelection();
            return;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_PreRender");
            return;
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_PreRenderComplete");
            return;
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_SaveStateComplete");
            return;
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_Render");
            return;
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            WriteToDebugDiv("Page_Unload");
            return;
        }

    }
}