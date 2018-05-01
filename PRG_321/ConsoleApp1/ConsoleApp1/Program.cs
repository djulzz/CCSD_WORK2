using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        { 
            int[] values = new int[5] { 1, 2, 3, 4, 5 };
            int[] values2 = new int[5];
            ArrayList values3 = new ArrayList();
            values3.Add(1);
            values3.Add("Hello");
            Console.WriteLine(values3[ 0 ].GetType() );
            Console.WriteLine(values3[1].GetType());
        }
    }
}
