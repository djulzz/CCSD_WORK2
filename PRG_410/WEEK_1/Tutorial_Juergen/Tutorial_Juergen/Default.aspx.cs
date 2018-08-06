using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Tutorial_Juergen
{
    public partial class Default : System.Web.UI.Page
    {
        private String mLastError;
        private MySqlConnection cnx;

        /// <summary>
        /// This Method takes a string as an input, and 
        /// analyzes if that input is an IPv4 address.
        /// </summary>
        /// <param name="input">
        /// A string potentially representing an IPv4 address
        /// </param>
        /// <returns>true if the string is IPv4, or false otherwise </returns>
        bool IsAnIpAddress(String input )
        {
            bool res = false;
            string pattern = @"^\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}$";

            RegexOptions options = RegexOptions.Singleline;
            MatchCollection c = Regex.Matches(input, pattern, options);
            if (c.Count == 1)
                res = true;

            return res;
        }

        /// <summary>
        /// This Method takes a string as an input, and 
        /// analyzes if that input is a domain name.
        /// </summary>
        /// <param name="input">
        /// A string potentially representing a URL
        /// </param>
        /// <returns>true if the string is a domain name, or false otherwise</returns>
        bool IsDomainName( String input )
        {
            bool res = false;
            string pattern = @"^((http[s]?|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$";
            RegexOptions options = RegexOptions.Singleline;
            MatchCollection c = Regex.Matches(input, pattern, options);
            if (c.Count == 1)
                res = true;
            return res;
        }

        /// <summary>
        /// This method attempts to split a string accross the equal sign.
        /// Its purpose is to help making sure that that Q&A enters the
        /// config file parameters properly.
        /// </summary>
        /// <param name="input">
        /// An option string formed by the pair attribute/value, separated
        ///  by an equal sign character.
        /// </param>
        /// <returns>an array of string made of 2 string in
        /// case of success, an empty array of strings otherwise.
        /// </returns>
        String[] IsCnxParamWellFormed( String input )
        {
            char[] pattern = { '=' };
            String[] array = input.Split(pattern);
            return array;
        }

        /// <summary>
        /// This method applies RegExs to the Value corresponding to
        ///  the "Data Source" Attributes. After checking if the value is:
        ///  - a URL
        ///  - localhost
        ///  - IPv4
        /// </summary>
        /// <param name="Value">
        /// The value corresponding to the attribute "Data Source".
        /// </param>
        /// <returns>
        /// True if the value is valid, false otherwise.
        /// </returns>
        bool IsDataSourceValid( String Value )
        {
            bool res = false;
            bool isIpAddress = IsAnIpAddress(Value);
            bool isURL = IsDomainName(Value);
            bool isLocalHost = (Value == "localhost");
            res = isIpAddress || isURL || isLocalHost;
            return res;

        }

        /// <summary>
        /// By default, for config.txt, an empty password is
        /// indicated by a value of "empty", but the connection
        ///  string only accepts "" for empty password. This
        ///   method does the replacement for us.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>A String with proper password content.</returns>
        String AdjustValueForEmptyPassword( String Value )
        {
            String returned_password;
            if (Value == "empty") {
                returned_password = "\"\"";
            } else {
                returned_password = Value;
            }
            return returned_password;
        }

        /// <summary>
        /// This method grabs all the parameters from a config file, and
        /// return a MySQL Connection String
        /// </summary>
        /// <returns>
        /// A MySQL Connection String.
        /// </returns>
        /// <remarks>
        /// Currently will access multiple time the same attributes.
        /// </remarks>
        String GetParametersFromFile()
        {
            String res = "";
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Esposito\Documents\GitHub\CCSD_WORK2\PRG_410\WEEK_1\Tutorial_Juergen\Tutorial_Juergen\bin\config.txt");
            if (file == null) {
                String msg = "file missing";
                throw new ConfigFileException(msg);
            }

            String line;
            while ((line = file.ReadLine()) != null) {
                /**
                 * If the line obtained from the file 
                 * contains the name data source, we know
                 * we are going to have to pay special attention
                 * to the member to the right of the equal sign,
                 * because that member could be:
                 * - a keyword (aka, localhost)
                 * - a server address
                 * - an IPv4 address
                 */

                String[] AttributeValuePair = IsCnxParamWellFormed(line);
                if( AttributeValuePair.Length != 2 ) {
                    String msg = "The pair Attribute / Value is not properly formed.";
                    throw new ConfigFileException(msg);
                }

                String Attribute = AttributeValuePair[0];
                String Value = AttributeValuePair[1];

                if (Attribute.Contains("Data Source")) {
                    if (!IsDataSourceValid(Value)) {
                        String msg = "The parameter on the right hand side of the \"Data Source\" is invalid. Check out the documentation.";
                        throw new ConfigFileException( msg );
                    }
                }
                if( Attribute.Contains("Password")) {
                    Value = AdjustValueForEmptyPassword( Value );
                }
                if (!line.Contains("SSL Mode"))
                    res += line + ";";
                else
                    res += line;
            }
            return res;
        }

        public void InitializeMySQLConnection( String configFilePath )
        {
            String connection_params = "";
            try {
                connection_params = GetParametersFromFile();
            }
            catch (Exception ex) {
                mLastError = ex.Message;
            }

            cnx = new MySqlConnection(connection_params);

            try
            {
                cnx.Open();
            }
            catch (Exception ex)
            {
                mLastError = ex.Message;
            }
            finally
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                    mLastError = "Connection is now open";
                else
                    mLastError = "Connection failed to open";
            }

            String s = "";
            try
            {
                s = GetParametersFromFile();
            }
            catch (Exception ex)
            {
                mLastError = ex.Message;
            }
            finally
            {
                Response.Write(s);
            }
            return;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeMySQLConnection(@"C:\Users\Esposito\Documents\GitHub\CCSD_WORK2\PRG_410\WEEK_1\Tutorial_Juergen\Tutorial_Juergen\bin\config.txt");
        }
    }
}