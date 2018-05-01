using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03
{
    class Program
    {
        public static void RunAssignment()
        {
            StreamReader inputFile = new StreamReader("numbers.txt");
            String content = "";
            //int[] arr = new int[100];
            List<Int32> values = new List<Int32>();
            while (content != null)
                } }

                static void Main(string[] args)
        {
            //String filename = "sample.txt";
            //if( File.Exists( filename ))
            //{
            //    Console.WriteLine("The filename: {0}", filename);
            //    Console.WriteLine("Attributes: {0}", File.GetAttributes(filename));
            //    Console.WriteLine("Ceated: {0}", File.GetCreationTime(filename));

            //    Console.WriteLine("Using foreach");
            //    DirectoryInfo dir = new DirectoryInfo( "." );
            //    foreach( FileInfo nfo in dir.GetFiles("*.*"))
            //    {
            //        Console.WriteLine(nfo.Name);
            //    }
            //    Console.WriteLine("Without Using foreach");
            //    FileInfo[] allTheFiles = dir.GetFiles("*.*");
            //    int numFiles = allTheFiles.Length;
            //    for( int i = 0; i < numFiles; i++ )
            //    {
            //        Console.WriteLine(allTheFiles[i].Name);
            //    }
            //}

            //Assignment3ReadingIntegersFromFile.RunAssignment();
            Assessment3Scores.Run();
        }
    }
}
