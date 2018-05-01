using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private int selected_index;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        
    }
    protected void Page_InitComplete(object sender, EventArgs e)
    {

    }
    protected void Page_PreLoad(object sender, EventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (IsPostBack)
        //{

        //}
        if( !IsPostBack)
        {
            selected_index = -1;
        }
        //Response.Write("<h1 style=\"color: blue;\">My Dynamically Generated Web Page</h1>");
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {

    }
    protected void Page_PreRender(object sender, EventArgs e)
    {

    }
    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {

    }
    protected void Page_SaveStateComplete(object sender, EventArgs e)
    {

    }
    protected void Page_Render(object sender, EventArgs e)
    {
        if (ListBox1.Items.Count >= 0)
        {


            //int selection_index = ListBox1.SelectedIndex;

            //if (selection_index != -1)
            //{
            //ListItem item = ListBox1.Items[selection_index];
            Label4.Text = ListBox1.SelectedItem.Text;
            //}
        }
    }
    protected void Page_Unload(object sender, EventArgs e)
    {

    }

    protected void OnClick(object sender, EventArgs e)
    {
        String content = TextBox1.Text;
        if( String.Empty == content )
        {
            return;
        }
        ListBox1.Items.Add(content);
    }

    protected void OnSelectedIndedChanged(object sender, EventArgs e)
    {
        String s = "Julien";
        int sz = ListBox1.Items.Count;
        if (-1 != selected_index)
        {
            String content = ListBox1.SelectedItem.ToString();
            //ListItem item = ListBox1.Items[selected_index];
            Label4.Text = content;
        }
    }
}