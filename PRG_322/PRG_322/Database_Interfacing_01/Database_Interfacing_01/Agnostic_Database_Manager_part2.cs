using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Database_Interfacing_01
{
    public partial class Agnostic_DataBase_Manager
    {
        #region methods
        public Agnostic_DataBase_Manager()
        {
            mCurrentErrorMessage = "None";
            InitializeDatabase();
        }
        public List<Student> ExtractData()
        {
            List<Student> list = new List<Student>();
            String query_string = "select * from student";
            MySqlCommand cmd = new MySqlCommand(query_string, myConnection);
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                bool CanIReadData = rdr.Read();
                if (CanIReadData == true)
                {
                    while (CanIReadData == true)
                    {
                        int student_id = (int)rdr["student_id"];
                        String firstName = (String)rdr["first_name"];
                        String lastName = (String)rdr["last_name"];
                        Student s = new Student(student_id, firstName, lastName);
                        //mlist.Add(s);
                        list.Add(s);
                        CanIReadData = rdr.Read();

                    }
                }
            }
            return list;
        }
        #endregion

        #region properties
        public String LastError
        {
            get
            {
                return mCurrentErrorMessage;
            }
        }
        #endregion
    }
}
