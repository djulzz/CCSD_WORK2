using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    public partial class Week02 : Form
    {
        Coach c1;
        Coach c2;
        public Week02()
        {
            InitializeComponent();

            c1 = new Coach();
            c1.FirstName = "Julien";
            c1.LastName = "Esposito";

            //c2 = new Coach(c1);
            c2 = c1;

            SportTeam t = new SportTeam();
            SportTeam_Football tf = new SportTeam_Football();
            SportTeam_Tennis tt = new SportTeam_Tennis();

            label1.Text = t.ShowClassName();
        }
    }
}
