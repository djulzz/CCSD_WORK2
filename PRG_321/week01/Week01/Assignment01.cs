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
    public partial class Assignment01 : Form
    {
        public Assignment01()
        {
            InitializeComponent();
        }

        private void Clear_Entries(object sender, EventArgs e)
        {
            m_textBox_first_input.Text = "";
            m_textBox_Second_Input.Text = "";
            m_label_Feedback.Text = "";
        }

        private void Exit_Application(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
