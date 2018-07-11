using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Login
{
    public class DB
    {
        public static String s(String txt)
        {
            return "'" + txt + "'";
        }

        public static String sc(String txt)
        {
            return s(txt) + ", ";
        }
        public static bool UserExists(String login, String pwd, String email, ref MySqlConnection cnx, out String potential_error )
        {
            String error = "none";
            bool result = false;
            String query = "SELECT LOGIN, PASSWORD, EMAIL FROM ENTRIES WHERE(LOGIN = " + DB.s(login) + ")" + " AND (PASSWORD = " + s(pwd) + ")" + " AND (EMAIL = " + s(email) + ")";
            MySqlCommand cmd = new MySqlCommand(query, cnx );
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                    result = true;
            }
            catch (Exception exc)
            {
                error = exc.Message;
                // NO PRINTING --> We don't know the context of use
            }
            potential_error = error;
            return result;
        }
        public static bool AddUser(String login, String pwd, String email, ref MySqlConnection cnx )
        {
            bool result = false;
            String query = "INSERT INTO ENTRIES( LOGIN, PASSWORD, EMAIL ) VALUES( " + sc(login) + sc(pwd) + s(email) + ");";
            MySqlCommand cmd = new MySqlCommand(query, cnx );
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ;
            }
            return result;
        }
    }
}