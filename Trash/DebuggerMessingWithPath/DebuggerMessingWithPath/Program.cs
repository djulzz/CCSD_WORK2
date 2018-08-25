using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DebuggerMessingWithPath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"C:\Users\djulzz\Documents\GitHub\CCSD_WORK2\Trash\DebuggerMessingWithPath\DebuggerMessingWithPath\bin\Debug\TestFile.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
