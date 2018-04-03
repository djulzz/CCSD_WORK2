using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class StudentEditor : System.Web.UI.Page
{
    private String selected_student_id;

    protected string oldLast;
    protected void Page_Load(object sender, EventArgs e)
    {

        // Is PostBack means the page is refreshing
        if (IsPostBack)
        {
            //selected_student_id = Request.QueryString["student_id"];
            if (Session["before"] != null)
            {
                oldLast = ((Student)Session["before"]).Last;
            }
        }
        else
        {
            m_TextBox_student_id.Text = Request.QueryString["student_id"];
            m_TextBox_FirstName.Text = Request.QueryString["firstName"];
            m_TextBox_lastName.Text = Request.QueryString["lastName"];
        }

        //m_TextBox_student_id.ReadOnly = false;
        //m_TextBox_FirstName.ReadOnly = false;
        //m_TextBox_lastName.ReadOnly = false;
        //}


    }

    protected void Validate_Changes(object sender, EventArgs e)
    {
        MySqlConnection con = (MySqlConnection)Session["MySqlConnection"];
        String firstName = m_TextBox_FirstName.Text;
        String lastName = m_TextBox_lastName.Text;

        String sql_command = "update students set firstName = '" + m_TextBox_FirstName.Text + "', lastName = '" + m_TextBox_lastName.Text + "' where (student_id = " + m_TextBox_student_id.Text + ")";
        //Response.Write(sql_command + "<br/>");
        Response.Write(oldLast + " was changed " + lastName);
        // String query = "select * from students where student_id = " + student_id;
        MySqlCommand cmd = new MySqlCommand(sql_command, con);
        cmd.ExecuteNonQuery();
        Student s = new Student("Bob", oldLast);
        Session["before"] = s;
        Response.Redirect("Default.aspx");
    }

    protected void Text_Changed_student_id(object sender, EventArgs e)
    {

    }

    protected void Text_Changed_FirstName(object sender, EventArgs e)
    {
        new_FirstName = ((TextBox)sender).Text;
        Response.Write(new_FirstName);
    }

    protected void Text_Changed_LastName(object sender, EventArgs e)
    {
        new_LastName = ((TextBox)sender).Text;
        Response.Write(new_LastName);
    }
}