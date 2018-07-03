using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Interfacing_01;

namespace That_Form_Though
{
    public partial class That_Form_Though : Form
    {
        public That_Form_Though()
        {
            InitializeComponent();
            Agnostic_DataBase_Manager mng = new Agnostic_DataBase_Manager();
            List< Student > lst = mng.ExtractData();
            int numStudents = lst.Count;
            for( int i = 0; i < numStudents; i++ )
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell[] cells = new DataGridViewTextBoxCell[3];
                for (int column_index = 0; column_index < 3; column_index++)
                {
                    cells[column_index] = new DataGridViewTextBoxCell();
                    //if (column_index == 0)
                    //    cells[column_index].Value = lst[i].ID;
                    //else if (column_index == 1)
                    //    cells[column_index].Value = lst[i].FirstName;
                    //else
                    //    cells[column_index].Value = lst[i].LastName;
                    cells[column_index].Value = lst[i][column_index];
                    row.Cells.Add(cells[column_index]);
                }
                dataGridView1.Rows.Add(row);
            }
        }

    }
}
