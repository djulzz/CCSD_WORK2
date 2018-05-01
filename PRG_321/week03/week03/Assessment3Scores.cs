using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace week03
{
    unsafe struct Record
    {
        String FirstName;
        String LastName;
        public fixed double scores[ 3 ];

    }
    public class Assessment3Scores
    {
        public static void Run()
        {
            int[] ar = new int[3];

            StreamWriter streamWriter = new StreamWriter("records.txt");
            streamWriter.WriteLine("Julien Esposito 66.0 93.0 55.4");
            streamWriter.WriteLine("Brandon Blau 77.0  28.0   100.0");
            streamWriter.WriteLine("Jordan Gross 44.0 58.0     100.0");
            streamWriter.Close();

            String buffer = String.Empty;
            string pattern = @"^([a-zA-Z]+[[:blank:]]+[a-zA-Z]+[[:blank:]]+)";
            StreamReader streamReader = new StreamReader("records.txt");
            do
            {
                buffer = streamReader.ReadLine();
                if (null != buffer)
                {
                    int size_String = buffer.Length;
                    int firstDigit = 0;
                    String number = "";
                    for ( int i = 0; i < size_String; i++ )
                    {
                        if( ( buffer[ i ] >= '0' ) && ( buffer[ i ] <= '9' ) )
                        {
                            firstDigit = i;
                            number = buffer.Substring(firstDigit);
                            break;
                        }
                    }
                    Console.WriteLine("grades = <" + number + ">");
                    string pattern2 = @"([[:digit:]]+[.]{0,1}+[[:digit:]]{0,5})";
                    foreach( Match m in Regex.Matches( number, pattern2 ) )
                    {
                        Console.WriteLine("{0} {1}", m.Index, m.Value);
                    }
                }
            } while (buffer != null);
            //Record[] array_scores =
            //    {
            //        new Record() { "Julien", "Esposito", { 1.0, 2.0, 3.0 } }
            //    };

            Console.WriteLine("Title - Assessment #3 - Reading Scores from File");
        }
    }
}
