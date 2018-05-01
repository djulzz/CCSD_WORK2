using System;
using Week2_Tutorial;

namespace Tutorial
{
    class Banana
    {
        static void Main(string[] args)
        {
            int a = 2; // whole number
            float b = 2.545678f; // decimal number which
                                 // can hold simple precision
                                 // decimal numbers
            double c = 3.6584658647367856348;

            String d = "Aaron";

            // the following example is commented out, as
            // it serves to show why classes are needed (such we
            // can regroup common attributes).
            // Example of common attributes:
            // - first name
            // - last name
            // - student id

            String s_FirstName_Student_1 = "Aaron";
            String s_LastName_Student_2 = "Esposito";
            
            int s_StudentID_1 = 1;
            s_StudentID_1 = 2;

            String s_FirstName_Student_2 = "Julien";
            String s_LastName_Student_1 = "Ausejo";
            int s_StudentID_2 = 2;

            Student s = new Student();
            //s.
            Console.WriteLine("first Name for 1st student = " + s_FirstName_Student_2);
        }
    }
}
