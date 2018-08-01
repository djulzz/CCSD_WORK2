using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;

namespace ParsingConfigFile
{
    class ConfigFileParser
    {
        static bool ValueIsIPv4( String candidate )
        {
            bool result = false;
            string pattern = @"^\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}$";
            RegexOptions options = RegexOptions.Singleline;
            MatchCollection collection = Regex.Matches(candidate, pattern, options);
            if (collection.Count == 1)
            {
                result = true;
            }
            return result;
        }

        static string[] Process(string filename )
        {
            string[] output = new string[5];
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(filename );
            if( file == null )
            {
                String msg = "file missing";
                throw new ConfigFileException(msg);
            }
            string pattern = @"^[a-zA-Z0-9_ ]*=[a-zA-Z0-9_ ]*$";
            RegexOptions options = RegexOptions.Singleline;
            int regex_count = 0;
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {

                string input = line;
                count++;
                MatchCollection collection = Regex.Matches(input, pattern, options);
                if( collection.Count != 1 )
                {
                    Console.WriteLine("QA, please don't mness with Gods.");
                    break;
                } else
                {
                    Match m = collection[0];
                    String value = input.Substring(input.LastIndexOf('='));
                    if ( count == 1 )
                    {
                        // this is where we will perform 2 additional checks
                        // for the case where the entry processed is the
                        // Data Source, because we want to ensure that
                        // the value found matches:
                        // - either an IPV4 address
                        // - or a domain name
                        bool isIpv4 = ValueIsIPv4(value);
                        if( isIpv4 == false )
                        {
                            bool isValidURL = ValueIsURL(value);
                            if( false == isValidURL )
                            {
                                throw new ConfigFileException("Data Source is invalid ");
                            }

                        }
                    }

                    output[counter] = value;
                    regex_count++;
                }
                counter++;
            }

            if(regex_count == 5 )
            {
                Console.WriteLine("Good Job - QA");
            } else
            {
                String msg = "Data Inconsistent";
                throw new ConfigFileException( msg );
            }
            file.Close();
            return output;
        }
        

    }
}
