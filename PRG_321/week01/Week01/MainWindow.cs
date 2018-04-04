using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week01
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Handle_Click(object sender, EventArgs e)
        {
            // put code to react to a "onClick" event
            // When clicking on m_button_clickMe, the click generates
            // a click event, which ha been wired to the "Handle_Click"
            // event handler in MS Form Designer.

            String firstName = m_textBox_FirstName.Text;
            //bool res = firstName.IsNullOrEmpty()
            if ( String.IsNullOrEmpty( firstName ))
            {
                return;
            }
            String greeting = "Hello, " + firstName;
            m_label_feedback.Text = greeting;
        }
    }
}
