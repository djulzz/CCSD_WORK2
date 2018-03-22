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
    public partial class F1 : Form
    {
        private F2 m_f2;
        public F1()
        {
            InitializeComponent();
            m_f2 = new F2( this);
        }

        private void ShowF2HideF1(object sender, EventArgs e)
        {
            m_f2.Show();
            this.Hide();
        }
    }
}
