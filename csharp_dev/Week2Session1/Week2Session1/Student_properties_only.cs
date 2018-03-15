using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Session1
{
    public partial class Student
    {
        public int ID
        {
            set
            {
                if (value < 0)
                {
                    return;
                }
            }

            get
            {
                return student_id;
            }
        }
    }
}
