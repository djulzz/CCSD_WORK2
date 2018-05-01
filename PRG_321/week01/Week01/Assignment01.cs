using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        private double Perfom_Operation( String operation )
        {
            double result = 0;
            double i1, i2;
            i1 = i2 = 0;

            Regex regex = new Regex(@"^[-+]?\d+(\.\d+)?$");
            Match match = regex.Match(m_textBox_first_input.Text);
            if (match.Success)
            {
                MessageBox.Show("You've entered a valid decimal number");
            } else
            {
                MessageBox.Show("No!");
            }
            return result;

            try
            {
                i1 = Convert.ToDouble(m_textBox_first_input.Text);
            } catch( Exception e )
            {
                MessageBox.Show("Error - " + e.Message);
                return result;
            }

            try
            {
                i2 = Convert.ToDouble(m_textBox_Second_Input.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error - " + e.Message);
                return result;
            }

            if( operation == "+")
            {
                result = i1 + i2;
            }
            if( operation == "*")
            {
                result = i1 * i2;
            }
            return result;
        }
        private void Handle_Operation(object sender, EventArgs e)
        {
            // determine which control was fired
            String controlType = sender.ToString();
            if (controlType.Contains("TextBox"))
            {
                TextBox box = (TextBox)sender;
                return;
            }

            if (controlType.Contains("Button"))
            {
                Button btn = (Button)sender;
                String sign_clicked = btn.Text;
                double res = Perfom_Operation(sign_clicked);
                m_label_Feedback.Text = Convert.ToString(res);
            }
        }
    }
}
