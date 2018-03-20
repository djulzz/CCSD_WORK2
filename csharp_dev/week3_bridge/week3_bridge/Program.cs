using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[2];
            shapes[0] = new Rectangle(2, 4);
            shapes[1] = new Circle(2, 0, 0);


            for( int i = 0; i < 2; i++ )
            {
                Console.WriteLine("This shape's area = " + shapes[i].getArea());
            }

            Console.ReadLine();
        }
    }
}
