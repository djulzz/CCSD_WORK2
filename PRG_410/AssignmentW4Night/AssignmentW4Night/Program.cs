using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentW4Night
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[3];
            IShape[] shapes = new IShape[3];
            shapes[0] = new Circle(2.0);
            shapes[1] = new Triangle( 4.0, 2.0);
            shapes[2] = new Rectangle(4.0, 2.0);

            for( int i = 0; i < shapes.Length; i++ )
            {
                String type = shapes[i].Type();
                double area = shapes[i].Area();
                double perim = shapes[i].Perimeter();
                Console.WriteLine("Type = {0} - Area = {1} - Perimeter = {2}", type, area, perim);
            }

            Student s = new Student("Julien");

            System.Xml.Serialization.XmlSerializer writer =
           new System.Xml.Serialization.XmlSerializer(typeof(Student));
            String SaveLocation = ".";
            System.IO.FileStream file = System.IO.File.Create(SaveLocation);

            writer.Serialize(file, s);
            Circle c = new Circle(4);
            c.Radius = -1;
            Console.Read();
        }
    }
}
