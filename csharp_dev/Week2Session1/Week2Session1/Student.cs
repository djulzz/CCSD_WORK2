using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Session1
{
    public partial class Student
    {
        private int student_id;
        private int age;
        private String NameF;
        private string NameL;

        public Student()
        {
            student_id = 100;
            age = 18;
            NameF = "Robert";
            NameL = "Paulson";
        }

        void SetId( int id )
        {
            if (id < 0)
            {
                Console.WriteLine("Only positive values are accepted for student id");
                return;
            }
            student_id = id;
        }
    }
}
