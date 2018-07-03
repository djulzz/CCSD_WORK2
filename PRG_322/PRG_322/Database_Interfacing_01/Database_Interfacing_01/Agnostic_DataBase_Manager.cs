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
        #region member_variables
        protected List<Student> mlist;
        protected MySqlConnection myConnection;
        protected String mCurrentErrorMessage;
        #endregion

        #region constructors
        protected void InitializeDatabase()
        {
            myConnection = new MySqlConnection();
            myConnection.ConnectionString = "Persist Security Info=False;database=class;server=localhost;Connect Timeout=30;user id=root; SslMode=none";
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                mCurrentErrorMessage = "Oops - Cnx not open - reason - " + ex.Message;
                return;
            }
            if (myConnection.State == System.Data.ConnectionState.Open)
            {
                mCurrentErrorMessage = "connection established";
            }
            else
            {
                mCurrentErrorMessage = "connection failed";
                return;
            }
        }
        #endregion

    }

}
