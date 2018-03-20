using System;

namespace Week2Session1
{
    class Program
    {
        public static double ReadDoubleValue( )
        {
            double value = 0;
            if (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Read();
            }
            return value;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // The following code extract shows how
            // to rea user input.

            Console.WriteLine("Enter the price for granola bar");
            double granolaPrice = ReadDoubleValue();
            Console.WriteLine("The price entered is = " + granolaPrice);
            Console.Read();
        }
    }
}
