using System;

namespace p717N10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Housing house = new Housing();
            MultiUnit multi_room = new MultiUnit();
            SingleFamily houseFamily = new SingleFamily();
            houseFamily.SquareFootage = 2500;
            houseFamily.GarageAvailable = true;

            Console.WriteLine("Printing \"Housing house\" = " + house );
            Console.WriteLine("Printing \"MultiUnit house\" = " + multi_room);
            Console.WriteLine("Printing \"SingleFamily houseFamily\" = " + houseFamily);

            Console.ReadLine();
        }
    }
}
