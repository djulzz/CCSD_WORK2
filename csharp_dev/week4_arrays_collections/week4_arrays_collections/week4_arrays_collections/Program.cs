using System;

namespace week4_arrays_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            for( int i = 0; i < 10; i++ )
            {
                myArray[i] = 10 * i;
                Console.WriteLine("The value at location " + i + " is " + myArray[i]);
            }

            int value = myArray[10];
            //for( int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("The value at location " + i + " is " + myArray[i]);
            //}
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
