using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class F2 : Form
    {
        private F1 m_f1;

        public F2( F1 f1 )
        {
            InitializeComponent();
            m_f1 = f1;
        }

        private void F2_Load(object sender, EventArgs e)
        {

        }

        private void ShowF1HideF2(object sender, EventArgs e)
        {
            m_f1.Show();
            this.Hide();
        }
    }
}
