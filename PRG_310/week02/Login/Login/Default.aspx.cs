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
        private List<Button> lst;

        public Default() : base()
        {
            lst = new List<Button>();
        }
        protected void PopulateListOfButtonsWithUserInfo()
        {
            
            String query_string = "SELECT LOGIN, PASSWORD, EMAIL FROM";
            query_string += " ENTRIES";
            MySqlCommand cmd = new MySqlCommand(query_string, connection);
            using( MySqlDataReader rdr = cmd.ExecuteReader() )
            {
                if( rdr.Read() )
                {
                    Label_Error.Text = "Reader is working";
                    String s = ",";
                    do
                    {
                        String login = (String)rdr["login"];
                        String pwd = (String)rdr["password"];
                        String email = (String)rdr["email"];
                        String caption = login + s + pwd + s + email;
                        Button b = new Button();
                        b.Text = caption;
                        lst.Add(b);
                    } while (rdr.Read());

                }
                else
                {
                    Label_Error.Text = "Reader is broken";
                }
                //rdr.Close();
            }
            return;
        }

        protected void OnDynamicClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String caption = b.Text;
            char[] separator = { ',' };
            String[] elements = caption.Split(separator );
            String login = elements[0];
            String pwd = elements[1];
            String email = elements[2];
            Response.Write("login = " + login);

            Label_Error.Text = "About to edit user with login " + login + " and password = " + pwd + " and email " + email;
            String query_string = "EditUser.aspx?login=" + login + "&pwd=" + pwd + "&email=" + email;
            Response.Redirect(query_string);
        }
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

                // this is new: "the list"
                PopulateListOfButtonsWithUserInfo();
                Session["list"] = lst;
                Table asp_table = Awesome_Table;
                int numberCustomers = lst.Count;
                for (int i = 0; i < numberCustomers; i++)
                {

                
                    lst[i].Click += OnDynamicClick;
                    TableCell cell = new TableCell();
                    cell.Text = lst[i].Text;
                    cell.Controls.Add(lst[i]);
                    TableRow tr = new TableRow();
                    tr.Cells.Add(cell);
                    Table_Dynamic.Rows.Add(tr);
                }
            } else // The page is not post back, we
                   // must recover the list of buttons
            {
                connection = (MySqlConnection)Session["connection"];
                lst = (List<Button>)Session["list"];
                int numberCustomers = lst.Count;
                for (int i = 0; i < numberCustomers; i++)
                {


                    lst[i].Click += OnDynamicClick;
                    TableCell cell = new TableCell();
                    cell.Text = lst[i].Text;
                    cell.Controls.Add(lst[i]);
                    TableRow tr = new TableRow();
                    tr.Cells.Add(cell);
                    Table_Dynamic.Rows.Add(tr);
                }
            }

            Label_Error.Text = "In Default.aspx, the table nums of row is " + lst.Count;
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