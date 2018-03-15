using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Session1
{
    public partial class Student
    {
        public int GetID()
        {
            return student_id;
        }

        public static void UnitTest()
        {
            Student s = new Student();
            s.SetId(666);
            int id = s.GetID();
            id = s.ID;
            Console.WriteLine("Our student ID = " + id );
            Console.Read();
        }
    }
}

