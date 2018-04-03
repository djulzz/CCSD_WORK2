using System;
using System.Collections.Generic;

namespace week4_arrays_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray da = new DynamicArray();
            da.Push(0);
            da.Push(1);
            da.Push(2);
            da.Push(3);

            da.Debug();
            da[0] = 3;
            List<int> ls = new List<int>();
            int[] myArray = new int[10];

            for( int i = 0; i < 10; i++ )
            {
                myArray[i] = 10 * i;
                Console.WriteLine("The value at location " + i + " is " + myArray[i]);
            }

            // first create an array to save all elements of the original
            int[] temp = new int[ myArray.Length ];

            // Saving the original array
            for( int i = 0; i < myArray.Length; i++ )
            {
                temp[i] = myArray[i];
            }

            // we now re - allocate our original array
            myArray = new int[100];
            for (int i = 0; i < temp.Length; i++)
            {
                myArray[i] = temp[i];
            }
            try
            {
                int value = myArray[10];
                Console.WriteLine("acessing location 11th is now possible");
            }
            catch( Exception ex )
            {
                Console.WriteLine("Error while accesing array element - Reason: " + ex.Message);
            }
            //for( int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("The value at location " + i + " is " + myArray[i]);
            //}

            //MorningEmployee ME = new MorningEmployee();
            //int[] theArray = ME.Array;

            //ArrayList<int> myList = new ArrayList<int>();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
