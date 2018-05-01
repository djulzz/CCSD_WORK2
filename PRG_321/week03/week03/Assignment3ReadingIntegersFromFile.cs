using System;
using System.IO;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03
{
    public class Assignment3ReadingIntegersFromFile
    {
        public static int FindMin( int[] input )
        {
            int result = input[0];
            for( int i = 0; i < input.Length; i++ )
            {
                if( result > input[ i ] )
                {
                    result = input[i];
                }
            }
            return result;
        }
        public static int FindMin( List<int> input )
        {
            int result = input[0];
            for (int i = 0; i < input.Count; i++)
            {
                if (result > input[i])
                {
                    //Console.WriteLine("(result < input[i]) = (" + result + " < " + input[ i ] + ")");
                    result = input[i];
                    
                }
            }
            return result;
        }

        public static int FindMax( int[] input )
        {
            int result = input[0];
            for( int i = 0; i < input.Length; i++ )
            {
                if( result < input[ i ] )
                {
                    result = input[i];
                }
            }
            return result;
        }

        public static void RunAssignment()
        {
            StreamReader inputFile = new StreamReader("numbers.txt");
            String content = "";
            //int[] arr = new int[100];
            List<Int32> values = new List<Int32>();
            while (content != null)
            {
                content = inputFile.ReadLine();
                if (content == null)
                {
                    inputFile.Close();
                    break;

                }
                try
                {
                    int temp = Convert.ToInt32(content);
                    values.Add(temp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error converting to a number fro,m file. Reason = " + e.Message);
                    break; // break here gets us out of the while loop
                }
            }
            inputFile.Close();
            Console.WriteLine("The array contains " + values.Count + " elements");
            //foreach( var number in values )
            //{
            //    Console.WriteLine("The current value is = " + number);
            //}

            Console.WriteLine("Min = " + values.Min() + " - Max = " + values.Max());
            int[] array = { 1, 2, 3, 4, 5 };
            int min = FindMin( values );
            Console.WriteLine("Your min is = " + min);
        }
    }
}
