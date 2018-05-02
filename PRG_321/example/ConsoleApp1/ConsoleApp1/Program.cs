using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            s = new Student();
            Console.WriteLine("Hi, my name is <" + s.GetFirstName() + ">");

            s.SetFirstName("");
            //s.firstName = "";

            Console.WriteLine("Hi, my name is <" + s.GetFirstName() + ">");
        }
    }
}
