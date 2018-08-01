using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ParsingConfigFile_Night
{
    public class DBConnectionInitializer
    {
        //static bool IsURL( String input )
        //{
        //    String pattern = "[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*);
        //}
        static String[] Process( String filename )
        {

            string pattern = @"^[a-zA-Z0-9_ ]*=[a-zA-Z0-9_ ]*$";
            string line = "empty";
            System.IO.StreamReader file = new System.IO.StreamReader(filename );
            RegexOptions options = RegexOptions.Singleline;
            int preliminary_pattern_count = 0;
            int line_count = 0;
            while (line != null) {
                line = file.ReadLine();
                line_count++;
                Console.WriteLine("<" + line + ">");

                if (!String.IsNullOrEmpty(line))
                {
                    MatchCollection collection = Regex.Matches(line, pattern, options);
                    if (collection.Count != 1)
                    {
                        Console.WriteLine("Data not properly entered - Aborting");
                    }
                    else
                    {
                        Console.WriteLine("Pattern Match Applied Successfully at entry # " + preliminary_pattern_count);
                        preliminary_pattern_count++;
                    }
                }
            }
        }
    }
}
